using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_18520560_LeKimDanh
{
    public partial class UDPClient : Form
    {
        UdpClient udpClient = new UdpClient();
        public UDPClient()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Int32 port = Int32.Parse(tbPort.Text);
            IPAddress ip = IPAddress.Parse(tbIP.Text.Trim());
            IPEndPoint ipEndPoint = new IPEndPoint(ip, port);
            byte[] content = UTF32Encoding.UTF32.GetBytes(rtbMessage.Text);
            try
            {
                int count = udpClient.Send(content, content.Length, ipEndPoint);
                if (0 < count)
                {
                    //MessageBox.Show("Message has been sent!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtbMessage.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error occurs.", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
