using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_18520560_LeKimDanh
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Form b1 = new Lab03_Bai01();
            b1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Form b2 = new Lab03_Bai02();
            b2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Form b3 = new Lab03_Bai03();
            b3.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Form b4 = new Lab03_Bai04();
            b4.Show();
        }
    }
}
