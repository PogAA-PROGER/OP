using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int n =  hScrollBar1.Value;
            label1.Text = Convert.ToString(n);
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                double result = (1 + Math.Pow(-1, hScrollBar1.Value) * (5 * Math.Pow(hScrollBar1.Value, 2) - 5 * Math.Pow(hScrollBar1.Value, 4) - 2 * Math.Pow(hScrollBar1.Value, 5) - 1))/4;
                label4.Text = Convert.ToString(result);
            }
            if (checkBox1.Checked)
            {
                double result = 0;
                for(int i = 1; i < hScrollBar1.Value+1 ; i++)
                {
                    result += Math.Pow((-1), i - 1) * Math.Pow(i, 5); 
                }
                label4.Text = Convert.ToString(result);
            }
        } 
    }
}
