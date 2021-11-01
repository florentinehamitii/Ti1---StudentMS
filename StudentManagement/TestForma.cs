using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMS_BLL;
namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public static DataTable lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateParentList();
        }
        public void PopulateParentList()
        {
            ParentBLL p1 = new ParentBLL();
            lista = p1.ShowAllParent();
            dgvParent.DataSource = lista;
        }
    }
}
