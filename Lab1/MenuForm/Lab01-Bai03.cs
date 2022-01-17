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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_TextChanged);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số từ 0-9!", "Thông báo");
                e.Handled = true;                
            }
            if(textBox1.Text.Length > 0)
            {
                MessageBox.Show("Vui lòng nhập số từ 0-9!", "Thông báo");
                e.Handled = true;                
            }
        }

        private void Lab01_Bai03_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "0":
                    textBox2.Text = "Không";
                    break;
                case "1":
                    textBox2.Text = "Một";
                    break;
                case "2":
                    textBox2.Text = "Hai";
                    break;
                case "3":
                    textBox2.Text = "Ba";
                    break;
                case "4":
                    textBox2.Text = "Bốn";
                    break;
                case "5":
                    textBox2.Text = "Năm";
                    break;
                case "6":
                    textBox2.Text = "Sáu";
                    break;
                case "7":
                    textBox2.Text = "Bảy";
                    break;
                case "8":
                    textBox2.Text = "Tám";
                    break;
                case "9":
                    textBox2.Text = "Chín";
                    break;
            }
        }
    }
}
