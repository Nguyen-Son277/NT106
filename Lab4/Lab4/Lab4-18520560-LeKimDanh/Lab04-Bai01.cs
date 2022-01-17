using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_18520560_LeKimDanh
{
    public partial class Lab04_Bai01 : Form
    {
        public Lab04_Bai01()
        {
            InitializeComponent();
        }

        private void btnGET_Click(object sender, EventArgs e)
        {
            try
            {
                rtbSource.Text = getHTML(txtURL.Text);
            }
            catch
            {
                MessageBox.Show("URL không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtURL.Text = "http://";
            }
        }

        private string getHTML(string strURL)
        {
            WebRequest request = WebRequest.Create(strURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGET.PerformClick();
        }
    }
}
