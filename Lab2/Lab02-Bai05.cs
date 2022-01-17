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

namespace Lab2_18520560_LeKimDanh
{
    public partial class Lab02_Bai05 : Form
    {
        public Lab02_Bai05()
        {
            InitializeComponent();
            LoadListView();
        }

        void LoadListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Tên");
            listView1.Columns.Add("Kích thước");
            listView1.Columns.Add("Đuôi mở rộng");
            listView1.Columns.Add("Ngày khởi tạo");               
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                FileInfo[] fiArr = di.GetFiles();
                foreach (FileInfo file in fiArr)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = file.Name;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.Length.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.Extension });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.CreationTime.ToString() });
                    listView1.Items.Add(item);
                }
            }
        }        
    }
}
