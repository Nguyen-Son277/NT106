using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_18520560_LeKimDanh
{
    public partial class ChatTCPServer : Form
    {
        IPEndPoint ipep;
        Socket server;        
        List<Socket> listClient;
        string str;
        public ChatTCPServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;            
        }        

        private void btnListen_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Hide();
            StartUnsafeThread();
        }

        void StartUnsafeThread()
        {
            listClient = new List<Socket>();
            ipep = new IPEndPoint(IPAddress.Any, 8080);
            rtbData.Text = "Server running on 127.0.0.1:8080\n";
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            Thread listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        server.Listen(100);                        
                        Socket client1 = server.Accept();
                        listClient.Add(client1);                        
                        rtbData.Text += "New client connected from " + client1.RemoteEndPoint.ToString() + "\n";

                        Thread recei = new Thread(receive);
                        recei.IsBackground = true;
                        recei.Start(client1);
                    }
                }
                catch
                {
                    ipep = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        void receive(object obj)
        {
            Socket client = obj as Socket;
            Byte[] data = new byte[1024];
            while (true)
            {

                client.Receive(data);
                str = UTF32Encoding.UTF32.GetString(data);
                rtbData.Text += client.RemoteEndPoint.ToString() + ": " + str + "\n";

                foreach (Socket socket in listClient)
                {
                    socket.Send(data);
                }
                data = new byte[1024];
            }

        }

        private void ChatTCPServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Close();
        }
    }
}
