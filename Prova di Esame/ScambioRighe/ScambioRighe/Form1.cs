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
using System.Collections;

namespace ScambioRighe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            Random random=new Random();
            ArrayList numeri = new ArrayList();
             int casuale;
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
                {
                    TextBox temp = (TextBox)tableLayoutPanel1.GetControlFromPosition(i, j);
                    do
                    {
                        casuale = random.Next(100);
                        numeri.Add(casuale);
                        temp.Text = casuale.ToString();
                    } while (!numeri.Contains(casuale));
                }
            }
        }

        private void btnScambia_Click(object sender, EventArgs e)
        {
            int riga1=int.Parse(Interaction.InputBox("Indice della prima riga che si vuole scambiare","Scambia righe","",-1,-1));
            int riga2=int.Parse(Interaction.InputBox("Indice della seconda riga che si vuole scambiare", "Scambia righe", "", -1, -1));
            String contenuto;
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                TextBox box=(TextBox)tableLayoutPanel1.GetControlFromPosition(i, riga1);
                TextBox box2 = (TextBox)tableLayoutPanel1.GetControlFromPosition(i, riga2);
                contenuto=box.Text;
                box.Text = box2.Text;
                box2.Text=contenuto;
            }
        }
    }
}
