using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMS_DAL;

namespace StudentManagement.MainForms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        //add code that closes the parent form
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Ju lutem shkruani emrin e përdoruesit.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    using (DatabaseConnection.conn = new SqlConnection(DatabaseConnection.connString))
                    {
                        DatabaseConnection.da = new SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE UserName = '"+ txtUserName.Text +"' AND UserPASS = '"+ txtPassword.Text +"'", DatabaseConnection.conn);
                        DataTable dTable = new DataTable();
                        DatabaseConnection.da.Fill(dTable);

                        if (dTable.Rows[0][0].ToString() == "1")
                        {
                            
                            this.Hide();
                            new AdminForms.AdminView().Show();
                        }
                        else
                            MessageBox.Show("Emri ose Fjalëkalimi është i gabuar.");
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
