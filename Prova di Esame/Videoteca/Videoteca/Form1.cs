using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Videoteca
{
    public struct Film
    {
        private int codice;

        public int Codice
        {
            get { return codice; }
            set { codice = value; }
        }
        private String titolo;

        public String Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }
        private int anno;

        public int Anno
        {
            get { return anno; }
            set { anno = value; }
        }
        private string attori;

        public string Attori
        {
            get { return attori; }
            set { attori = value; }
        }
        public Film(int codice, String titolo, int anno, String attori)
        {
            this.codice = codice;
            this.titolo=titolo;
            this.anno=anno;
            this.attori=attori;
        }
    }
    public partial class Form1 : Form
    {
        private ArrayList lista = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            if (!txtAnno.Text.Equals("") || !txtCod.Text.Equals("") || !txtAtt.Text.Equals("") || !txtTit.Text.Equals(""))
            {
                lista.Add(new Film(int.Parse(txtCod.Text),txtTit.Text,int.Parse(txtAnno.Text),txtAtt.Text));
            }
        }

        private void btnVis_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            foreach (Film ele in lista)
            {
                listView1.Items.Add(new ListViewItem(new String[]{ele.Codice.ToString() ,ele.Titolo, ele.Anno.ToString(), ele.Attori}));
            }
        }


    }
}
