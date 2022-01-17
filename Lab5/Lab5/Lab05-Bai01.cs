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
    public partial class Lab05_Bai01 : Form
    {
        public Lab05_Bai01()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 8;
        }

        void SendMail()
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = txtSender.Text.Trim();
                string mailto = txtRecipient.Text.Trim();
                string password = txtPassword.Text.Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    message.From = fromAddress;
                    message.Subject = txtSubject.Text.Trim();

                    message.IsBodyHtml = false;
                    message.Body = rtxBody.Text.Trim();
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

        string mail1 = "danhle@18520560.nt106";
        string mail2 = "ledanh@18520560.nt106";
        string mail3 = "kimdanh@18520560.nt106";

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtSender.Text == string.Empty || txtRecipient.Text == string.Empty)
            {
                MessageBox.Show("Nhập đủ mail người nhận và người gửi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Nhập password!");
            }
            else
            {
                if ((txtSender.Text == mail1 || txtSender.Text == mail2 || txtSender.Text == mail3)
                    && (txtRecipient.Text == mail1 || txtRecipient.Text == mail2 || txtRecipient.Text == mail3)
                    && txtPassword.Text == "Nt106J21")
                {
                    SendMail();
                }
                else if (txtPassword.Text.Trim() != "Nt106J21")
                {                    
                    MessageBox.Show("Sai mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Mail không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
