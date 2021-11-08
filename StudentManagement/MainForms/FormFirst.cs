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
    public partial class FormFirst : Form
    {
        public FormFirst()
        {
            InitializeComponent();
        }
        MainForms.MenuLogin menuLogIn = new MainForms.MenuLogin();


        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuLogIn.Show();
        }
    }
}
