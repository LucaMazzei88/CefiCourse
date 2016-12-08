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

namespace EsercizioCriterio
{
    public partial class Form1 : Form
    {
        ArrayList list = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader leggi = new StreamReader("numeri.txt");
            while(!leggi.EndOfStream)
                list.Add(leggi.ReadLine());
            leggi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double conta = 0;
            bool flag = true;
            int[] numeri;
            string[] temp;
            foreach (string ele in list) {
                temp=ele.Split(',');
                numeri=new int[temp.Length];
                for (int i = 0; i < temp.Length;i++ )
                {
                    numeri[i] = int.Parse(temp[i]);
                }
                for (int i = 1; i < numeri.Length; i++)
                {
                    if (numeri[i] != numeri[i - 1] + i)
                    {
                        flag=false;
                    }
                }
                if (flag)
                    conta++;
            }
            conta /= list.Count;
            txtMedia.Text = conta.ToString();
        }
    }
}
