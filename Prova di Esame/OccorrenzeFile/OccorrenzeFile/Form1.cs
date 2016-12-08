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
namespace OccorrenzeFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashSet<int> lista = new HashSet<int>();
            string numeri;
            string[] dati;
            int occorrenze = 0;
            foreach (TextBox temp in tableLayoutPanel1.Controls)
            {
                    lista.Add(int.Parse(temp.Text));
            }
            if (lista.Count < tableLayoutPanel1.Controls.Count)
            {
                MessageBox.Show("Errore di inserimento dei dati, dati ripetuti");
                return;
            }
            foreach (int i in lista)
            {
                if (i < 0 || i > 30)
                {
                    MessageBox.Show("Dati inseriti non corretti, inserisci numeri tra 0 - 30");
                    return;
                }
            }
            using (StreamReader leggi = new StreamReader("numeri.txt"))
            {
                numeri = leggi.ReadToEnd();
            }
            dati = numeri.Split(',');
            foreach (int i in lista)
            {
                foreach (string ele in dati)
                {
                    if (int.Parse(ele) == i)
                    {
                        occorrenze++;
                    }
                }
            }
            txtSomma.Text = occorrenze.ToString();
        }
    }
}

