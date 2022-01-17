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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form b5 = new Lab01_Bai05();
            b5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form b1 = new Lab01_Bai01();
            b1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form b2 = new Lab01_Bai02();
            b2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form b3 = new Lab01_Bai03();
            b3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form b4 = new Lab01_Bai04();
            b4.ShowDialog();
        }
    }
}
