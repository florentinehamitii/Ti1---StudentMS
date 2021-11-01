using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_BO;
using StudentMS_DAL;

namespace StudentMS_BLL
{
    class CourseBLL
    {
        CourseDAL cDAL = new CourseDAL();
        public bool CreateCourse(CourseBO course)
        {
            return cDAL.InsertCourses(course);
        }
    }
}
