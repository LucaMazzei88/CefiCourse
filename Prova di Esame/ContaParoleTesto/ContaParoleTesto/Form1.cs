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

namespace ContaParoleTesto
{
    public partial class Form1 : Form
    {
        private string testo;
        private SortedDictionary<int,int> conteggio=new SortedDictionary<int,int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            StreamReader leggi = new StreamReader("testo.txt");
            testo=leggi.ReadToEnd();
            leggi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lung=0;
            string[] parole = testo.Split(arrayNotLetter(),StringSplitOptions.RemoveEmptyEntries);

            foreach (string ele in parole)
            {
                lung=ele.Length;
                
                if(conteggio.ContainsKey(lung)){
                    conteggio[lung]++;
                }else{
                    conteggio.Add(lung,1);
                }
            }
            foreach(KeyValuePair<int,int> ele in conteggio){
                listBox1.Items.Add("Parole lunghe "+ele.Key+" caratteri: "+ele.Value);
            }
        }
        private String[] arrayNotLetter()
        {
           char temp;
            String[] arr=new String[205];
            int contatoreArr = 0;
            for (int c = 0; c < 255; c++)
            {
                temp = (char)c;
                if (!char.IsLetter(temp)) {
                    arr[contatoreArr++] = new string(temp,1);
                    Console.WriteLine(temp);
                }
            }
            return arr;
        }
    }
}
