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

namespace MediaCategorie
{
    public partial class Form1 : Form
    {
        SortedDictionary<String, int> somme=new SortedDictionary<string,int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] temp;
            int sommaQuan = 0;
            int conta=0;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Categoria";
            dataGridView1.Columns[1].Name = "Quantità";
            StreamReader leggi=new StreamReader("elementi.txt");
            while(!leggi.EndOfStream){
                conta++;
                temp=leggi.ReadLine().Split(';');
                if (somme.ContainsKey(temp[4]))
                {
                    somme[temp[4]] += int.Parse(temp[2]);
                    sommaQuan += somme[temp[4]];
                }
                else { 
                    somme.Add(temp[4], int.Parse(temp[2]));
                    sommaQuan += somme[temp[4]];
                }
            }
            foreach(KeyValuePair<string,int> ele in somme){
                dataGridView1.Rows.Add(ele.Key, ele.Value);
            }
            txtMedia.Text = (sommaQuan / conta).ToString();
        }
    }
}
