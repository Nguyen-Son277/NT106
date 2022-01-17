using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab2_18520560_LeKimDanh
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "|*.txt";
            ofd.ValidateNames = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                fs.Close();
            }
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            int lines = richTextBox1.Lines.Length;            
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "|*.txt", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        for(int j=0; j < lines; ++j)
                        {
                            string content = richTextBox1.Lines[j];
                            string result = "";
                            result = content + "=" + Calculate(content).ToString();
                            sw.WriteLine(result);
                        }
                        sw.Close();
                        MessageBox.Show("Bạn đã lưu file thành công!", "Thông báo");
                    }
                }
            }
        }    
        
        public static string Calculate(string str)
        {
            int position = -1;
            char op = ' ';
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                {
                    position = i;
                    op = str[i];
                    break;
                }
            }

            int a = Convert.ToInt32(str.Substring(0, position));
            int b = Convert.ToInt32(str.Substring(position + 1));
            int result = 0;
            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
            }
            return result.ToString();
        }
    }
}
