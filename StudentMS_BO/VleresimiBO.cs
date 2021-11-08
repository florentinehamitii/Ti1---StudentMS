using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    public class VleresimiBO :Base
    {
        public int VleresimiID { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public int StudentID { get; set; }
        public int Testi1 { get; set; }
        public int Testi2 { get; set; }
        public int HomeWork { get; set; }
        public int FinalGrade { get; set; }
    }
}
