using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_18520560_LeKimDanh
{
    public partial class Lab03_Bai02 : Form
    {
        public Lab03_Bai02()
        {
            InitializeComponent();
        }

        Socket client, listen;
        private void btnListen_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Hide();
            rtbData.Text = "Telnet running on 127.0.0.1:8080\n";
            Thread thread = new Thread(new ThreadStart(StartUnsafeThread));
            thread.Start();
        }

        private void Lab03_Bai02_FormClosed(object sender, FormClosedEventArgs e)
        {
            listen.Close();
        }

        void StartUnsafeThread()
        {
            byte[] recv = new byte[1024];            
            listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listen.Bind(ipep);
            listen.Listen(-1);
            client = listen.Accept();
            if (rtbData.InvokeRequired)
            {
                rtbData.Invoke((MethodInvoker)delegate ()
                {                    
                    rtbData.Text += "New client connected\n";                    
                });
            }
            while (client.Connected)
            {
                client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv);
                if (rtbData.InvokeRequired)
                {
                    rtbData.Invoke((MethodInvoker)delegate ()
                    {                        
                        rtbData.Text += s;
                    });
                }
            }            
        }


    }
}
