﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_18520560_LeKimDanh
{
    public partial class SourceHTML : Form
    {
        public SourceHTML()
        {
            InitializeComponent();
        }
        
        public SourceHTML(string source):this()
        {
            rtbSource.Text = source;
        }
    }
}
