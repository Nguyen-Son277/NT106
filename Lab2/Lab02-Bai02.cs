using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_18520560_LeKimDanh
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "|*.txt";
            ofd.ValidateNames = true;
            ofd.Multiselect = false;
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                textBox1.Text = ofd.SafeFileName.ToString();
                textBox2.Text = fs.Name.ToString();
                int countChar = content.Length;                
                content = content.Replace("\r\n", "\r");
                int countLine = richTextBox1.Lines.Count();
                content = content.Replace('\r', ' ');
                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int countWord = source.Count();
                textBox3.Text = countLine.ToString();
                textBox4.Text = countWord.ToString();
                textBox5.Text = countChar.ToString();
                fs.Close();
            }
        }
    }
}
