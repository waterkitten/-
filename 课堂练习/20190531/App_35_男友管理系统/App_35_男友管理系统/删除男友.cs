﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_35_男友管理系统
{
    public partial class 删除男友 : Form
    {
        string str;
        
        public 删除男友()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;
        }

        public String STR
        { get { return str; } }
    }
}
