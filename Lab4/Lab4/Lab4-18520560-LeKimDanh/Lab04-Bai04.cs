using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_18520560_LeKimDanh
{
    public partial class Lab04_Bai04 : Form
    {
        public Lab04_Bai04()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGo.PerformClick();
        }

        private string getSource(string strURL)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = web.Load(strURL);
                string s = doc.Text;
                return s;
            }
            catch
            {
                return "URL không tồn tại!";
            }
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            if(getSource(txtURL.Text) == "URL không tồn tại!")
            {

            }
            else
            {
                SourceHTML source = new SourceHTML(getSource(txtURL.Text));
                source.Show();
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if(getSource(txtURL.Text) == "URL không tồn tại!")
            {                
                
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "HTML|*.html", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteLineAsync(getSource(txtURL.Text));
                            MessageBox.Show("Bạn đã tải source thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
