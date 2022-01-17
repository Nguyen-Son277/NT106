using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_18520560_LeKimDanh
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            Form b1 = new Lab02_Bai01();
            b1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form b2 = new Lab02_Bai02();
            b2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form b5 = new Lab02_Bai05();
            b5.ShowDialog();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Form b3 = new Lab02_Bai03();
            b3.ShowDialog();
        }
    }
}
