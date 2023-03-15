using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPR2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, baskara;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            if (a == 0 && b == 0 && c == 0)
            {
                MessageBox.Show("A, B e C devem ser diferentes de 0!");
            }
            else
            {
                delta = Math.Pow(b, 2 - 4 * a * c);
                if (delta < 0)
                {
                    MessageBox.Show("Delta não pode ser menor que 0! ");
                }
                else if (delta == 0)
                {
                    baskara = -b / (2 * a);
                }
                else
                {
                    baskara = -b + Math.Sqrt(delta) / (2 * a);
                    label5.Text = Convert.ToString(baskara);
                    baskara = -b - Math.Sqrt(delta) / (2 * a);
                    label6.Text = Convert.ToString(baskara);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
