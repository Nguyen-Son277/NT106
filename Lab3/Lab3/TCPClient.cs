using System;
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
using System.Net.WebSockets;
using System.IO;
using System.Net.Configuration;

namespace Lab3_18520560_LeKimDanh
{
    public partial class TCPClient : Form
    {
        IPEndPoint ipep;
        Socket client;       
        public TCPClient()
        {
            InitializeComponent();
            Connect();
        }                

        private void btnSend_Click(object sender, EventArgs e)
        {            
            string s = "Hello server!" + "\n";
            client.Send(Encoding.UTF8.GetBytes(s));
        }        

        private void Connect()
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            client.Connect(ipep);
        }        

        private void TCPClient_Load(object sender, EventArgs e)
        {
            
        }        

        private void TCPClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            string quit = "Quit ";
            client.Send(Encoding.UTF8.GetBytes(quit));            
        }
    }
}
