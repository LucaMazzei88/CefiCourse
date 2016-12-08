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
namespace ContaOccorrenze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<int,int>mappa = new Dictionary<int,int>();
            int chiave, valore;
            using (StreamReader leggi = new StreamReader("numeri.txt"))
            {
                while (!leggi.EndOfStream)
                {
                    chiave = int.Parse(leggi.ReadLine());
                    if (mappa.ContainsKey(chiave))
                    {
                        valore = (int)mappa[chiave];
                        mappa[chiave]= ++valore;
                    }
                    else
                        mappa.Add(chiave, 0);
                }
            }

            foreach (KeyValuePair<int, int> ele in mappa)
            {
                listBox1.Items.Add(ele.Key+"="+ele.Value);
            }
        }
    }
}
