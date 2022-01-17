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
    public partial class Lab03_Bai04 : Form
    {
        public Lab03_Bai04()
        {
            InitializeComponent();
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            Form server = new ChatTCPServer();
            server.Show();
        }

        private void btnOpennewClient_Click(object sender, EventArgs e)
        {
            Form client = new ChatTCPClient();
            client.Show();
        }
    }
}
