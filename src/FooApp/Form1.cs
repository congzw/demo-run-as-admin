﻿using System.Windows.Forms;

namespace FooApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.label1.Text = @"IsRunAsAdmin => " + RoleHelper.IsRunAsAdmin();
        }
    }
}
