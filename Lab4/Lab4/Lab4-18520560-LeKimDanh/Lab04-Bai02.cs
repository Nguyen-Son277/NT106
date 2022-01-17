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
    public partial class Lab04_Bai02 : Form
    {
        public Lab04_Bai02()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if(txtContent.Text != string.Empty)
            {
                rtbResponse.Text = getResponse(txtURL.Text);
            }
            else
            {
                MessageBox.Show("Nhập gì đó vào nội dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string getResponse(string strURL)
        {
            WebRequest request = WebRequest.Create(strURL);
            request.Method = "POST";

            string postData = txtContent.Text;
            byte[] byteArray = UTF32Encoding.UTF32.GetBytes(postData);

            request.ContentType = "application/x-www-form-urlencoded";

            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();

            WebResponse response = request.GetResponse();

            MessageBox.Show(((HttpWebResponse)response).StatusDescription, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }

        private void txtContent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnPost.PerformClick();
            }
        }
    }
}
