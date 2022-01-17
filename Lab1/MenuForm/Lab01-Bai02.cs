using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_TextChanged);
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_TextChanged);
            textBox3.KeyPress += new KeyPressEventHandler(textBox3_TextChanged);
        }

        private void Lab1_Bai02_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double max = Math.Max(a, Math.Max(b, c));
            double min = Math.Min(a, Math.Min(b, c));
            textBox5.Text = min.ToString();
            textBox4.Text = max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                MessageBox.Show("Vui lòng nhập số!", "Thông báo");
                e.Handled = true;                
            }
        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                MessageBox.Show("Vui lòng nhập số!", "Thông báo");
                e.Handled = true;             
            }
        }

        private void textBox3_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                MessageBox.Show("Vui lòng nhập số!", "Thông báo");
                e.Handled = true;                
            }
        }
    }
}
