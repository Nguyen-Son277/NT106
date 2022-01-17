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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_TextChanged);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "USD(Đô-la Mỹ)":
                    label3.Text = "1 USD = 22,772 VND";
                    break;
                case "EUR(Euro)":
                    label3.Text = "1 EUR = 28,132 VND";
                    break;
                case "GBP(Bảng Anh)":
                    label3.Text = "1 GBP = 31,538 VND";
                    break;
                case "SGD(Đô-la Singapore)":
                    label3.Text = "1 SGD = 17,286 VND";
                    break;
                case "JPY(Yên Nhật)":
                    label3.Text = " 1 JPY = 214 VND";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Chỉ nhập số!", "Thông báo");
                e.Handled = true;                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Chọn loại tiền!", "Thông báo");
            }
            double a = double.Parse(textBox1.Text);
            double usd = a * 22772, eur = a * 28132, gbp = a * 31538, sgd = a * 17286, jpy = a * 214;
            switch (comboBox1.Text)
            {
                case "USD(Đô-la Mỹ)":
                    textBox2.Text = usd.ToString();
                    break;
                case "EUR(Euro)":
                    textBox2.Text = eur.ToString();
                    break;
                case "GBP(Bảng Anh)":
                    textBox2.Text = gbp.ToString();
                    break;
                case "SGD(Đô-la Singapore)":
                    textBox2.Text = sgd.ToString();
                    break;
                case "JPY(Yên Nhật)":
                    textBox2.Text = jpy.ToString();
                    break;
            }
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
