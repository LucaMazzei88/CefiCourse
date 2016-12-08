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
using System.IO;

namespace SalvareDatiCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog apri = new SaveFileDialog();
            apri.Filter = "Testo|*.txt";
            apri.Title = "Salva";
            apri.ShowDialog();
            if (apri.FileName != "")
            {
                 using (StreamWriter scrivi = new StreamWriter(apri.FileName, true))
                 {
                    scrivi.WriteLine(txtNome.Text+","+txtCognome.Text+","+txtIndirizzo.Text+","+txtCitta.Text+","+txtCap.Text);
                 }
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            txtNome.Text="";
            txtCognome.Text="";
            txtIndirizzo.Text="";
            txtCitta.Text="";
            txtCap.Text = "";
        }
    }
}
