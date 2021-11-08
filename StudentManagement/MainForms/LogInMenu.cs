using System;
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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        MainForms.LogIn login = new MainForms.LogIn();

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlLoginActive.Left = btnAdmin.Left;
            login.TopLevel = false;
            login.Parent = pnlLoginForm;
            login.Dock = DockStyle.Fill;
            login.Show();
            
                }
    }
}
