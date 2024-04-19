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

namespace OP10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sk = "";
            while (true)
            {
                double a;
                bool result = double.TryParse(textBox1.Text, out a);
                if (result == false | a < 0 | Convert.ToString(a) ==" ")
                {
                    MessageBox.Show("Введите положительное число");
                    textBox1.Text = "";
                    break;
                }
                else
                {
                    Sk = Convert.ToString(a);
                    break;
                }
            }
            string St = "";
            while (true)
            {
                double a;
                bool result = double.TryParse(textBox2.Text, out a);
                if (result == false | a < 0 | Convert.ToString(a) == " ")
                {
                    MessageBox.Show("Введите положительное число");
                    break;
                }
                else
                {
                    St = Convert.ToString(a);
                    break;
                }
            }
            string Kk = "";
            while (true)
            {
                double a;
                bool result = double.TryParse(textBox3.Text, out a);
                if (result == false | a < 0 | Convert.ToString(a) == " ")
                {
                    MessageBox.Show("Введите положительное число");
                    break;
                }
                else
                {
                    Kk = Convert.ToString(a);
                    break;
                }
            }
            string Kt = "";
            while (true)
            {
                double a;
                bool result = double.TryParse(textBox4.Text, out a);
                if (result == false | a < 0 | Convert.ToString(a) == " ")
                {
                    MessageBox.Show("Введите положительное число");
                    break;
                }
                else
                {
                    Kt = Convert.ToString(a);
                    break;
                }
            }
            double res = Convert.ToDouble(Sk)* Convert.ToDouble(Kk) + Convert.ToDouble(St) * Convert.ToDouble(Kt);
            label1.Text = Convert.ToString(res);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 0;
            while (true)
            {
                int a;
                bool result = int.TryParse(textBox5.Text, out a);
                if (result == false)
                {
                    MessageBox.Show("Введите целое число");
                    break;
                }
                else
                {
                    n = a;
                    break;
                }
            }
            int sum = 0;
            if (checkBox1.Checked)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    sum += i * i;
                }
            }
            if (checkBox2.Checked)
            {
                sum = n*(n + 1)*(2*n + 1)/6;
            }
            label9.Text = sum.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }
    }
}

