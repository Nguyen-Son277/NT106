using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_TextChanged);
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_TextChanged);
        }

        private void Lab01_Bai01_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {            
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))    
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo");
                e.Handled = true;                
            }            
        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo");
                e.Handled = true;                
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            long sum = a + b;
            textBox3.Text = sum.ToString();
        }
    }
}
