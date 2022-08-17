using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoDeBurbuja
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        public void ordenar(int[] lista)
        {
            int aux = 0;
            //textBox1.Text = "Vector desordenado" + Environment.NewLine;
            for (int i = 0; i < lista.Length-1 ; i++)
            {
                for (int x = 0; x < lista.Length -1; x++)
                {
                    if (lista[x] > lista[x + 1])
                    {
                        aux = lista[x];
                        lista[x] = lista[x + 1];
                        lista[x + 1] = aux;
                    }
                }

            }
            textBox1.Text += "Vector Ordenado" + Environment.NewLine;

            foreach (int item in lista)
            {
                textBox1.Text += item + Environment.NewLine;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] lista = { 10, 17, 1, 4, 6, 2, 3 };
            textBox1.Text = "Vector Desordenado"+ Environment.NewLine;

            foreach (int numero in lista)
            {
                textBox1.Text += numero + Environment.NewLine;
            }
            ordenar(lista);

            
        }
    }

}
