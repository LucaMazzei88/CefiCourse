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

namespace Studenti
{
    public partial class Form1 : Form
    {
        private ArrayList lista = new ArrayList();
        private Dictionary<String, ArrayList> voti = new Dictionary<string, ArrayList>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader leggi = new StreamReader("esami.txt");
            while (leggi.EndOfStream)
            {
                lista.Add(leggi.ReadLine().Split(new String[]{";"},StringSplitOptions.RemoveEmptyEntries));
            }
            leggi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList temp;
            int somme;
            foreach (String[] ele in lista)
            {
                if (voti.ContainsKey(ele[0]))
                {
                    temp=voti[ele[0]];
                    temp.Add(ele[2]);
                    voti[ele[0]] = temp;

                }else {
                    temp=new ArrayList();
                    temp.Add(ele[1]);
                    temp.Add(int.Parse(ele[2]));
                    voti.Add(ele[0],temp);
                }
            }
            foreach (KeyValuePair<string, ArrayList> ele in voti)
            {
                somme=0;
                ArrayList temp1=ele.Value;
                foreach(object ele1 in temp1){
                    try{
                        somme+=(int)ele1;
                    }catch(Exception){

                    }
                }
                string[] inserici = new string[] { ele.Key, temp1[0].ToString(), (somme / (temp1.Count - 1)).ToString() };
                listView1.Items.Add(new ListViewItem(inserici));
            }
        }
    }
}
