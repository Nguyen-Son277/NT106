using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_TextChanged);
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_TextChanged);
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số!", "Thông báo");
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số!", "Thông báo");
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if(textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            int a = int.Parse(textBox1.Text); //gt = 1, sum1 = 0;
            int b = int.Parse(textBox2.Text);// gt2 = 1,bigsum = 0, sum2 = 0;
            BigInteger gt = 1, sum1 = 0, gt2 = 1, bigsum = 0, sum2 = 0,tempt = 1;
            for (int i = 1; i <= a; ++i )
            {
                gt *= i;
                sum1 += i;
            }
            for(int i = 1; i<= b; ++i)
            {
                gt2 *= i;
                sum2 += i;                                
                tempt *= a;
                bigsum += tempt;
            }
            textBox3.Text = "A! = " + gt.ToString() + "\t\t" + "B! = "+ gt2.ToString() + "\r\n" + "S1 = 1 + 2 + 3 + 4 +...+ A = " + sum1.ToString() + "\r\n" + "S2 = 1 + 2 + 3 + 4 +...+ B = " + sum2.ToString() + "\r\n" + "S3 = A^1 + A^2 + A^3 + A^4 +...+ A^B = " + bigsum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
