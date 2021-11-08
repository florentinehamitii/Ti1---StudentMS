using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.MainForms
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }
        MainForms.LogIn login = new MainForms.LogIn();

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlLoginActive.Left = btnAdmin.Left;
            pnlLoginActive.BackColor = Color.Green;
            btnAdmin.BackColor = Color.FromArgb(216, 191, 216);
            login.TopLevel = false;
            login.Parent = pnlLoginForm;
            login.Dock = DockStyle.Fill;
            login.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            pnlLoginActive.Left = btnTeacher.Left;
            pnlLoginActive.BackColor = Color.DeepPink;
            login.TopLevel = false;
            login.Parent = pnlLoginForm;
            login.Dock = DockStyle.Fill;
            login.Show();

        }
    }
}
