using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_DAL;
using StudentMS_BO;

namespace StudentMS_BLL
{
    class TeacherBLL
    {
        private TeacherDAL tchDAL;
        public TeacherBLL()
        {
            tchDAL = new TeacherDAL();
        }
        public void InsertTeacher(TeacherBO t)
        {
            tchDAL.InsertTeachers(t);
        }
    }
}
