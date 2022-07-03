using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double estimate_pi(int n)
        {
            Random random = new Random();
            double a, b;
            double numpin_circle = 0, numpin_square = 0;
            for (int i = 0; i < n; i++)
            {
                a = GetRandomNumber(0.000000000000000001, 0.99999999999999999999999, random);
                b = GetRandomNumber(0.000000000000000001, 0.99999999999999999999999, random);
                double d = a * a + b * b;
                if (d <= 1)
                    numpin_circle++;
                numpin_square++;
            }
            return (4 * numpin_circle / numpin_square);
        }
        static double GetRandomNumber(double minimum, double maximum, Random random)
        {
            return random.NextDouble() * (maximum - minimum - 0.00000000000001) + minimum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(this.textBox1.Text);
                this.label4.Text = estimate_pi(n).ToString();
            }
            catch
            {
                MessageBox.Show("Trebuie sa introduceti un numar natural !","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
