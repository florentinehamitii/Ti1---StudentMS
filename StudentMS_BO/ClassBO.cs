using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
  public  class ClassBO: Base
    {
        public int ClassID { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public int Room { get; set; }
    }
}
