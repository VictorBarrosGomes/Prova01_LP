using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prova01___Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Codigo para Adicao
            int Numero_1, Numero_2, Result;

            Numero_1 = Convert.ToInt16(textBox1.Text);
            Numero_2 = Convert.ToInt16(textBox2.Text);

            Result = Numero_1 + Numero_2;

            label4.Text = Convert.ToString(Result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Codigo para Subtracao
            int Numero_1, Numero_2, Result;

            Numero_1 = Convert.ToInt16(textBox1.Text);
            Numero_2 = Convert.ToInt16(textBox2.Text);

            Result = Numero_1 - Numero_2;

            label4.Text = Convert.ToString(Result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Codigo para Multiplicacao
            int Numero_1, Numero_2, Result;

            Numero_1 = Convert.ToInt16(textBox1.Text);
            Numero_2 = Convert.ToInt16(textBox2.Text);

            Result = Numero_1 * Numero_2;

            label4.Text = Convert.ToString(Result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Codigo para Divisao
            float Numero_1, Numero_2, Result;

            Numero_1 = Convert.ToInt16(textBox1.Text);
            Numero_2 = Convert.ToInt16(textBox2.Text);

            Result = Numero_1 / Numero_2;

            label4.Text = Convert.ToString(Result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Limpar campos
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = (" ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
