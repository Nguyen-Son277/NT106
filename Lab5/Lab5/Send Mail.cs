using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_18520560_LeKimDanh
{
    public partial class Send_Mail : Form
    {
        public Send_Mail()
        {
            InitializeComponent();
        }

        string PASS;
        public Send_Mail(string user, string pass) : this()
        {
            txtSender.Text = user;
            PASS = pass;
        }

        void SendMail()
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = txtSender.Text.Trim();
                string mailto = txtRecipient.Text.Trim();
                string password = PASS.Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    message.From = fromAddress;
                    message.Subject = txtSubject.Text.Trim();

                    message.IsBodyHtml = false;
                    message.Body = rtbBody.Text.Trim();
                    message.To.Add(mailto);

                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Gửi mail thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {            
            SendMail();                      
        }
    }
}
