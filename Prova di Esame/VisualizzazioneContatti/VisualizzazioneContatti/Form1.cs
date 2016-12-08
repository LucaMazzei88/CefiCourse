using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace VisualizzazioneContatti
{
    public struct Persona
    {
        private String nomeECognome;

        public String NomeECognome
        {
            get { return nomeECognome; }
            set { nomeECognome = value; }
        }
        private String indirizzo;

        public String Indirizzo
        {
            get { return indirizzo; }
            set { indirizzo = value; }
        }
        private String citta;

        public String Citta
        {
            get { return citta; }
            set { citta = value; }
        }
        private int eta;

        public int Eta
        {
            get { return eta; }
            set { eta = value; }
        }
        public Persona(String nomeECognome, String indirizzo, String citta,int eta)
        {
            this.nomeECognome = nomeECognome;
            this.indirizzo = indirizzo;
            this.citta = citta;
            this.eta = eta;
        }

    }
    public partial class Form1 : Form
    {
        ArrayList lista = new ArrayList();
        int indice=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader leggi = new StreamReader("dati.txt");
            String[] temp;
            Persona p;
            while (!leggi.EndOfStream)
            {
                temp = leggi.ReadLine().Split(',');
                p = new Persona(temp[0], temp[1], temp[2], int.Parse(temp[3]));
                lista.Add(p);
            }
            visualizza((Persona)lista[indice]);
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            indice = 0;
            visualizza((Persona)lista[indice]);
        }

        private void btnPrecedente_Click(object sender, EventArgs e)
        {
            if (indice < lista.Count - 1)
            indice++;
            visualizza((Persona)lista[indice]);
        }

        private void btnProssimo_Click(object sender, EventArgs e)
        {
            if(indice>0)
                indice--;
            visualizza((Persona)lista[indice]);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            indice = lista.Count - 1;
            visualizza((Persona)lista[indice]);
        }
        private void visualizza(Persona p)
        {
            txtNome.Text = p.NomeECognome;
            txtIndirizzo.Text = p.Indirizzo;
            txtCitta.Text = p.Citta;
            txtEta.Text = p.Eta.ToString();
        }
    }
}
