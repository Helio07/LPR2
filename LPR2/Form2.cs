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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double a, b, c, r;
            a = double.Parse(textBoxA.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            r = (a + b) * c;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, r;
            a = double.Parse(textBoxA.Text);
            b = double.Parse(textBox3.Text);
            c = double.Parse(textBox2.Text);
            r = (a + b) * c;

            label8.Text = Convert.ToString(r);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
