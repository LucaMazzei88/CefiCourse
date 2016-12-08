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
using System.IO;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader leggi= new StreamReader("rubrica.txt");
            String[] temp;
            while(!leggi.EndOfStream){
                temp=leggi.ReadLine().Split('#');
                dataGridView1.Rows.Add(temp);
            }
            leggi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!txtNome.Text.Equals("") && !txtCogn.Text.Equals("") && !txtEmail.Text.Equals("") && !txtTel.Text.Equals(""))
                dataGridView1.Rows.Add(txtNome.Text, txtCogn.Text, txtTel.Text, txtEmail.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter scrivi = new StreamWriter("rubrica.txt");
            DataGridViewRowCollection riga = dataGridView1.Rows;
            for (int i = 0; i < riga.Count;i++)
            {
                scrivi.WriteLine(riga[i].Cells[0].Value.ToString() + "#"
                               + riga[i].Cells[1].Value.ToString() + "#"
                               + riga[i].Cells[2].Value.ToString() + "#"
                               + riga[i].Cells[3].Value.ToString());
            }
            scrivi.Close();
        }

    }
}
