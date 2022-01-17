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
    public partial class Lab04_Bai03 : Form
    {
        public Lab04_Bai03()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (txtURL.Text == "http://" || txtURL.Text == string.Empty)
            {
                MessageBox.Show("Nhập URL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPath.Text == string.Empty)
            {
                MessageBox.Show("Nhập đường dẫn lưu file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            if(txtPath.Text != string.Empty && txtURL.Text != "http://" && txtURL.Text != string.Empty)
            {
                try
                {
                    WebClient myClient = new WebClient();
                    Stream response = myClient.OpenRead(txtURL.Text);
                    myClient.DownloadFile(txtURL.Text, txtPath.Text);

                    StreamReader reader = new StreamReader(response);

                    rtbSource.Text = reader.ReadToEnd();
                }
                catch
                {
                    MessageBox.Show("URL không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtURL.Text = "http://";
                }
            }
        }
    }
}
