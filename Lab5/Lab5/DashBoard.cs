using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_18520560_LeKimDanh
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Form b1 = new Lab05_Bai01();
            b1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form b2 = new Lab05_Bai02();
            b2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form b3 = new Lab05_Bai03();
            b3.Show();
        }
    }
}
