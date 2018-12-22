using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        
        InitializeComponent();
        }
        private int[] vector;
        int iX = 50000;
        int i = 0;
        int ii = 0;
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int auxili;
            int j;
            ii = 0;

            Random r = new Random();

            vector = new int[iX];
            for (i = 0; i < iX; i++)
            {
              
                vector[i] = r.Next(10, 101);

            }


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "ITERACIONES METODO QUICKSHORT";
            for (int i = 0; i < iX; i++)
            {
                listBox1.Items.Add(vector[i]);
                // listBox2.Items.Add(r.Next(10, 101));

            }

            for (int i = 0; i < vector.Length; i++)
            {
                auxili = vector[i];
                j = i - 1;
                while (j >= 0 && vector[j] > auxili)
                {
                    vector[j + 1] = vector[j];
                    ii = ii + 1;
                    
                    textBox1.Text = Convert.ToString(ii);
                    j--;
                }
                vector[j + 1] = auxili;
            }

            for (int i = 0; i < iX; i++)
            {
                listBox2.Items.Add(vector[i]);
             
            }
            textBox2.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(vector[i]);
                // listBox2.Items.Add(r.Next(10, 101));
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int E1 = 0;
            ii = 0;

            Random r = new Random();

            vector = new int[iX];
            for (i = 0; i < iX; i++)
            {
               
                vector[i] = r.Next(10, 101);

            }

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Text = "";
            textBox3.Text = "";
            salto = vector.Length / 2;
            label1.Text = "ITERACIONES METODO SHELL";
            for (int i = 0; i < iX; i++)
            {
                listBox1.Items.Add(vector[i]);
               

            }

            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    E1 = 1;
                    while (E1 <= (vector.Length - salto))
                    {
                        if (vector[E1 - 1] > vector[(E1 - 1) + salto])
                        {
                            auxi = vector[(E1 - 1) + salto];
                            vector[(E1 - 1) + salto] = vector[E1 - 1];
                            vector[(E1 - 1)] = auxi;
                            sw = 1;
                            ii = ii + 1;
                            textBox1.Text = Convert.ToString(ii);
                        }
                        E1++;
                    }
                }
                salto = salto / 2;

            }
            for (int i = 0; i < iX; i++)
            {
                listBox2.Items.Add(vector[i]);
                // listBox2.Items.Add(r.Next(10, 101));

            }
            textBox3.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
