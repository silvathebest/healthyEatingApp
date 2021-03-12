﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace healthyEatingApp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonBeginTest_Click(object sender, EventArgs e)
        {
            Form f = new MainTest();
            f.Show();
            this.Visible = false;
        }
        private void buttonBeginCalc_Click(object sender, EventArgs e)
        {
            Form f = new Calc();
            f.Show();
            this.Visible = false;
        }
    }
}