﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0519
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text="杉田夏葵";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Top = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }
    }
}
