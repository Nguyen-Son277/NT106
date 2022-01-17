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
    public partial class Lab03_Bai01 : Form
    {
        public Lab03_Bai01()
        {
            InitializeComponent();
        }

        private void btnUDPServer_Click(object sender, EventArgs e)
        {
            Form udpServer = new UDPServer();
            udpServer.Show();
        }

        private void btnUDPClient_Click(object sender, EventArgs e)
        {
            Form udpClient = new UDPClient();
            udpClient.Show();
        }
    }
}
