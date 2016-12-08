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

namespace Esami
{
    public partial class Form1 : Form
    {
          private ArrayList stud = new ArrayList();
          private ArrayList esami=new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("non lo fare!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader leggi=new StreamReader("studenti.txt")){
                while (!leggi.EndOfStream)
                {
                    stud.Add(leggi.ReadLine().Split(','));
                }
            }
            using (StreamReader leggi = new StreamReader("esami.txt"))
            {
                while (!leggi.EndOfStream)
                {
                    esami.Add(leggi.ReadLine().Split(','));
                }
            }
            foreach (String[] ele in stud)
            {
                listView1.Items.Add(new ListViewItem(new String[]{ele[0],ele[1], calcolaMedia(ele[0]).ToString()}));
            }
        }
        private double calcolaMedia(String matricola)
        {
            int somma=0;
            int conta=0;
            foreach (String[] ele in esami)
            {
                if (ele[0].Equals(matricola))
                {
                    somma += int.Parse(ele[2]);
                    conta++;
                }
            }
            return ((double)somma / conta);
        }
    }
}
