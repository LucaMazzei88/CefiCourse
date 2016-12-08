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
namespace OrdinaTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList num = new ArrayList();
            foreach (TextBox ele in flowLayoutPanel1.Controls)
            {
                num.Add(int.Parse(ele.Text));
            }
            num.Sort();
            int i=0;
            foreach (TextBox ele in flowLayoutPanel1.Controls)
            {
                ele.Text = num[i++].ToString();
            }
        }
    }
}
