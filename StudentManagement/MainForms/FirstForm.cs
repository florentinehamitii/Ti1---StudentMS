﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        MainForms.MenuLogin menuLogIn = new MainForms.MenuLogin();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuLogIn.Show();


        }
    }
}
