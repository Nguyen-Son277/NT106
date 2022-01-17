using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_18520560_LeKimDanh
{
    public partial class ChatTCPClient : Form
    {
        public ChatTCPClient()
        {
            InitializeComponent();
            Connect();
            CheckForIllegalCrossThreadCalls = false;
        }

        Socket client;
        IPEndPoint ipep;        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbMessage.Text != "")
            {
                string content = tbName.Text + ": " + tbMessage.Text + "\n";
                client.Send(UTF32Encoding.UTF32.GetBytes(content));
                tbMessage.Clear();
            }
            else if (tbName.Text == "")
                MessageBox.Show("Điền tên của bạn");
            else if (tbMessage.Text == "")
                MessageBox.Show("Viết gì đó vào tin nhắn");
        }

        void Connect()
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(ipep);
            }
            catch { };
            Thread thread = new Thread(receive);
            thread.IsBackground = true;
            thread.Start();
        }

        void receive()
        {
            while(true)
            {
                Byte[] data = new byte[1024];
                client.Receive(data);
                if (data != null)
                    rtbListMessage.Text += UTF32Encoding.UTF32.GetString(data);
            }
        }

        private void ChatTCPClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            string content = tbName.Text + ": \"quit the chat room\""  + "\n";
            client.Send(UTF32Encoding.UTF32.GetBytes(content));            
        }
    }
}
