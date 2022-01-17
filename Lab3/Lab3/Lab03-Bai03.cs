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
    public partial class Lab03_Bai03 : Form
    {
        public Lab03_Bai03()
        {
            InitializeComponent();
        }

        private void btnTCPServer_Click(object sender, EventArgs e)
        {
            Form tcpServer = new TCPServer();
            tcpServer.Show();
        }

        private void btnTCPClient_Click(object sender, EventArgs e)
        {
            Form tcpClient = new TCPClient();
            tcpClient.Show();
        }
    }
}
