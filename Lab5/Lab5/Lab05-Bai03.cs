using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_18520560_LeKimDanh
{
    public partial class Lab05_Bai03 : Form
    {
        public Lab05_Bai03()
        {
            InitializeComponent();            
            lblInfo.Text = "Email Address";
            menuStrip1.Hide();
            lvlDetailEmail.Hide();
            label1.Hide();
            label.Hide();
            lblTotal.Hide();
            lblUnread.Hide();
            txtInfo.Clear();
            txtInfo.PasswordChar = '*';
            txtInfo.MaxLength = 14;
        }

        string mail1 = "danhle@18520560.nt106";
        string mail2 = "kimdanh@18520560.nt106";
        string mail3 = "ledanh@18520560.nt106";        
        
        string currentMail = "";
        string password = "";

        int mode = 1;        

        public bool checkMail(string s)
        {
            if (s == mail1 || s == mail2 || s == mail3)
            {
                return true;
            }
            return false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(1 == mode)
            {
                if (!checkMail(txtEmail.Text))
                {
                    lblWrong.Text = "Không tìm thấy email của bạn!";
                    lblWrong.ForeColor = Color.Red;
                }
                else
                {
                    currentMail = txtEmail.Text;
                    ++mode;
                    lblWrong.Text = string.Empty;
                    lblInfo.Text = "Password";
                    txtEmail.Hide();
                }
            }
            else
            {
                if (txtInfo.Text != "Nt106J21")
                {
                    lblWrong.Text = "Mật khẩu không đúng";
                    lblWrong.ForeColor = Color.Red;
                }
                else
                {
                    password = txtInfo.Text;
                    txtInfo.Hide();
                    btnNext.Hide();
                    lblWrong.Hide();
                    lblInfo.Hide();
                    pictureBox1.Hide();
                    label1.Show();
                    label.Show();
                    lblTotal.Show();
                    lblUnread.Show();
                    LoadListView();
                    lvlDetailEmail.Show();
                    menuStrip1.Show();
                    ReadMail();
                }
            }
        }
        void LoadListView()
        {
            lvlDetailEmail.Columns.Add("Subject", 200);
            lvlDetailEmail.Columns.Add("From", 200);
            lvlDetailEmail.Columns.Add("Date", 200);
            lvlDetailEmail.View = View.Details;
        }

        private void txtInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNext.PerformClick();
            }
        }

        void ReadMail()
        {
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("localhost", 993, true);

                client.Authenticate(currentMail, password);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                lblTotal.Text = inbox.Count.ToString();
                lblUnread.Text = inbox.Recent.ToString();

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);

                    ListViewItem item = new ListViewItem();
                    item.Text = message.Subject;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.From.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.Date.Date.ToString() });
                    lvlDetailEmail.Items.Add(item);
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvlDetailEmail.Clear();
            LoadListView();
            ReadMail();
        }

        private void newMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Send_Mail send = new Send_Mail(currentMail, password);
            send.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Hide();
            lvlDetailEmail.Hide();
            label.Hide();
            label1.Hide();
            lblTotal.Hide();
            lblUnread.Hide();
            pictureBox1.Show();
            lblInfo.Show();
            txtInfo.Show();
            txtInfo.Clear();
            txtEmail.Show();
            txtEmail.Clear();
            lblWrong.Show();
            btnNext.Show();
            lblInfo.Text = "Email Address";
            currentMail = "";
            password = "";
            mode =  1;
        }

        private void Lab05_Bai03_Load(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNext.PerformClick();
            }
        }
    }
}
