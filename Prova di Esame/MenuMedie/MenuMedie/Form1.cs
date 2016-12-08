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

namespace MenuMedie
{
    public partial class Form1 : Form
    {
        //String path;
        public Form1()
        {
            InitializeComponent();
        }

        private void chiudiùToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "testo|*.txt";
            if (op.ShowDialog() == DialogResult.OK)
            {
                StreamReader leggi = new StreamReader(op.FileName);
                while (!leggi.EndOfStream)
                {
                    listBox1.Items.Add(media(leggi.ReadLine()));
                }
            }
        }
        private double media(String s)
        {
            String[] temp = s.Split('-');
            double somme = 0;
            foreach(String ele in temp){
                somme += double.Parse(ele);
            }
            return somme / temp.Length;
        }
    }
}
