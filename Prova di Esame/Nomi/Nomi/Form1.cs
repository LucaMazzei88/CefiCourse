using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Nomi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            String temp="";
            int lung=0;
            foreach (String ele in listBox1.SelectedItems)
            {
                if (lung < ele.Length)
                {
                    temp = ele;
                    lung = ele.Length;
                }
                else if (lung == ele.Length)
                {
                    temp = (confrontaAscii(ele,temp)) ? ele : temp;
                }
            }
            textBox1.Text = temp;
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            string nome = Microsoft.VisualBasic.Interaction.InputBox("Inserisci","Inserimento","",-1,-1);
            listBox1.Items.Add(nome);
        }
        private bool confrontaAscii(string s, string s1)  //torna true se s>s1 false altrimenti
        {
            bool ris;
            int temp = 0, temp1 = 0;
            byte[] morsi = Encoding.ASCII.GetBytes(s);
            foreach (byte ele in morsi)
                temp += ele;
            byte[] morsi1 = Encoding.ASCII.GetBytes(s1);
            foreach (byte ele in morsi1)
                temp1 += ele;
            ris=(temp>temp1)? true: false;
            return ris;
        }
    }
}
