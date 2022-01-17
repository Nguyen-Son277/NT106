using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_18520560_LeKimDanh
{
    public partial class UDPServer : Form
    {
        public delegate void ShowMessage(string message);
        public ShowMessage myDelegate;
        Int32 port = 8080;
        UdpClient udpClient = new UdpClient(8080);
        Thread thread;
        public UDPServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Hide();
            richTextBox1.Text = "Start Listening" + "\n";
            myDelegate = new ShowMessage(ShowMessageMethod);
            thread = new Thread(new ThreadStart(ReceivedMessage));
            thread.IsBackground = true;
            thread.Start();
        }

        public void ReceivedMessage()
        {
            while (true)
            {
                IPEndPoint RemoteIPEndPoint = new IPEndPoint(IPAddress.Any, port);
                byte[] content = udpClient.Receive(ref RemoteIPEndPoint);                
                if (content.Length > 0)
                {
                    string message = RemoteIPEndPoint.Address.ToString() + ": " + UTF32Encoding.UTF32.GetString(content);
                    this.Invoke(myDelegate, new object[] { message });
                }
            }
        }

        private void ShowMessageMethod(string message)
        {
            richTextBox1.Text += message + "\n";
        }

    }
}
