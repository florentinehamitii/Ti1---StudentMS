using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.AdminForms
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }
        AdminForms.AddTeachers addTeach = new AdminForms.AddTeachers();
        AdminForms.DeleteTeachers delTch = new AdminForms.DeleteTeachers();
        AdminForms.UpdateTeachers updTch = new AdminForms.UpdateTeachers();
        AdminForms.AddCourses addCourse = new AdminForms.AddCourses();
        AdminForms.UpdateCourses updCourse = new AdminForms.UpdateCourses();
        AdminForms.DeleteCourses delCourse = new AdminForms.DeleteCourses();
      
      
       

        private void btnAddTeachers_Click_1(object sender, EventArgs e)
        {
            pnlActive.Height = btnAddTeachers.Height;
            pnlActive.Top = btnAddTeachers.Top;
            if (pnlContent.Contains(updTch))
            {
                updTch.Hide();
            }
            if (pnlContent.Contains(delTch))
            {
                delTch.Hide();
            }
            if (pnlContent.Contains(updCourse))
            {
                updCourse.Hide();
            }
            if (pnlContent.Contains(delCourse))
            {
                delCourse.Hide();
            }
            if (pnlContent.Contains(addCourse))
            {
                addCourse.Hide();
            }
            addTeach.TopLevel = false;
            addTeach.Parent = pnlContent;
            addTeach.Dock = DockStyle.Fill;
            addTeach.Show();

        }

        private void btnUpdateTeachers_Click_1(object sender, EventArgs e)
        {
            pnlActive.Height = btnUpdateTeachers.Height;
            pnlActive.Top = btnUpdateTeachers.Top;
            if (pnlContent.Contains(addTeach))
            {
                addTeach.Hide();
            }
            if (pnlContent.Contains(delTch))
            {
                delTch.Hide();
            }
            if (pnlContent.Contains(addCourse))
            {
                addCourse.Hide();
            }
            if (pnlContent.Contains(updCourse))
            {
                updCourse.Hide();
            }
            if (pnlContent.Contains(delCourse))
            {
                delCourse.Hide();
            }

            updTch.TopLevel = false;
            updTch.Parent = pnlContent;
            updTch.Dock = DockStyle.Fill;
            updTch.Show();
        }

        private void btnDelTeachers_Click_1(object sender, EventArgs e)
        {
            pnlActive.Height = btnDelTeachers.Height;
            pnlActive.Top = btnDelTeachers.Top;
            if (pnlContent.Contains(addTeach))
            {
                addTeach.Hide();
            }
            if (pnlContent.Contains(updTch))
            {
                updTch.Hide();
            }
            if (pnlContent.Contains(addCourse))
            {
                addCourse.Hide();
            }
            if (pnlContent.Contains(updCourse))
            {
                updCourse.Hide();
            }
            if (pnlContent.Contains(delCourse))
            {
                delCourse.Hide();
            }

            delTch.TopLevel = false;
            delTch.Parent = pnlContent;
            delTch.Dock = DockStyle.Fill;
            delTch.Show();
        }

        private void btnAddCourses_Click_1(object sender, EventArgs e)
        {
            pnlActive.Height = btnAddCourses.Height;
            pnlActive.Top = btnAddCourses.Top;
            if (pnlContent.Contains(addTeach))
            {
                addTeach.Hide();
            }
            if (pnlContent.Contains(updTch))
            {
                updTch.Hide();
            }
            if (pnlContent.Contains(delTch))
            {
                delTch.Hide();
            }
            if (pnlContent.Contains(updCourse))
            {
                updCourse.Hide();
            }
            if (pnlContent.Contains(delCourse))
            {
                delCourse.Hide();
            }


            addCourse.TopLevel = false;
            addCourse.Parent = pnlContent;
            addCourse.Dock = DockStyle.Fill;
            addCourse.Show();

        }

        private void btnUpdateCourses_Click_1(object sender, EventArgs e)
        {
            pnlActive.Height = btnUpdateCourses.Height;
            pnlActive.Top = btnUpdateCourses.Top;
            if (pnlContent.Contains(addTeach))
            {
                addTeach.Hide();
            }
            if (pnlContent.Contains(updTch))
            {
                updTch.Hide();
            }
            if (pnlContent.Contains(delTch))
            {
                delTch.Hide();
            }
            if (pnlContent.Contains(addCourse))
            {
                addCourse.Hide();
            }
            if (pnlContent.Contains(delCourse))
            {
                delCourse.Hide();
            }
            updCourse.TopLevel = false;
            updCourse.Parent = pnlContent;
            updCourse.Dock = DockStyle.Fill;
            updCourse.Show();
        }

        private void btnDeleteCourses_Click_1(object sender, EventArgs e)
        {
            pnlActive.Height = btnDeleteCourses.Height;
            pnlActive.Top = btnDeleteCourses.Top;
            if (pnlContent.Contains(addTeach))
            {
                addTeach.Hide();
            }
            if (pnlContent.Contains(updTch))
            {
                updTch.Hide();
            }
            if (pnlContent.Contains(delTch))
            {
                delTch.Hide();
            }
            if (pnlContent.Contains(updCourse))
            {
                updCourse.Hide();
            }
            if (pnlContent.Contains(delCourse))
            {
                delCourse.Hide();
            }

            delCourse.TopLevel = false;
            delCourse.Parent = pnlContent;
            delCourse.Dock = DockStyle.Fill;
            delCourse.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
