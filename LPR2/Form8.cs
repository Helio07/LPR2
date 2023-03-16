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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kmInicial, kmFinal, kmPercorrido, custoTotal;

            kmInicial = double.Parse(textBox1.Text);
            kmFinal = double.Parse(textBox2.Text);

            if (kmInicial > kmFinal)
            {
                kmPercorrido = -1 * (kmFinal - kmInicial);
                custoTotal = kmPercorrido * 0.85;
                label3.Text = ("KM percorrido: ") +Convert.ToString(kmPercorrido)+(" KM");
                label4.Text = ("Custo total da viagem: R$ ") + Convert.ToString(custoTotal) + (" KM");
            }
            else
            {
                kmPercorrido = kmFinal - kmInicial;
                custoTotal = kmPercorrido * 0.85;
                label3.Text = ("KM percorrido: ") + Convert.ToString(kmPercorrido) + (" KM");
                label4.Text = ("Custo total da viagem: R$ ") + Convert.ToString(custoTotal) + (" KM");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
