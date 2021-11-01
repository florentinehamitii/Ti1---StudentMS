using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.TeacherForms
{
    public partial class TeacherView : Form
    {
        TeacherForms.AddGrades addGrade = new TeacherForms.AddGrades();
        TeacherForms.EditGrades editGrade = new TeacherForms.EditGrades();
        TeacherForms.DeleteGrades delGrade = new TeacherForms.DeleteGrades();
        TeacherForms.ViewCourses viewCourses = new TeacherForms.ViewCourses();
        public TeacherView()
        {
            InitializeComponent();
        }

        private void btnAddGrades_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnAddGrades.Height;
            pnlActive.Top = btnAddGrades.Top;
            if (pnlContent.Contains(editGrade))
            {
                editGrade.Hide();
            }
            if (pnlContent.Contains(delGrade))
            {
                delGrade.Hide();
            }
            if (pnlContent.Contains(viewCourses))
            {
                viewCourses.Hide();
            }
            
            addGrade.TopLevel = false;
            addGrade.Parent = pnlContent;
            addGrade.Dock = DockStyle.Fill;
            addGrade.Show();
        }

        private void btnUpdGrades_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnUpdGrades.Height;
            pnlActive.Top = btnUpdGrades.Top;
            if (pnlContent.Contains(addGrade))
            {
                addGrade.Hide();
            }
            if (pnlContent.Contains(delGrade))
            {
                delGrade.Hide();
            }
            if (pnlContent.Contains(viewCourses))
            {
                viewCourses.Hide();
            }
            editGrade.TopLevel = false;
            editGrade.Parent = pnlContent;
            editGrade.Dock = DockStyle.Fill;
            editGrade.Show();
        }

        private void btnDelGrades_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnDelGrades.Height;
            pnlActive.Top = btnDelGrades.Top;
            if (pnlContent.Contains(addGrade))
            {
                addGrade.Hide();
            }
            if (pnlContent.Contains(editGrade))
            {
                editGrade.Hide();
            }
            if (pnlContent.Contains(viewCourses))
            {
                viewCourses.Hide();
            }
            delGrade.TopLevel = false;
            delGrade.Parent = pnlContent;
            delGrade.Dock = DockStyle.Fill;
            delGrade.Show();
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnViewCourses.Height;
            pnlActive.Top = btnViewCourses.Top;
            if (pnlContent.Contains(addGrade))
            {
                addGrade.Hide();
            }
            if (pnlContent.Contains(editGrade))
            {
                editGrade.Hide();
            }
            if (pnlContent.Contains(delGrade))
            {
                delGrade.Hide();
            }
            viewCourses.TopLevel = false;
            viewCourses.Parent = pnlContent;
            viewCourses.Dock = DockStyle.Fill;
            viewCourses.Show();
        }
    }
}
