using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
   public class CourseBO : Base
    {
        public int CourseID { get; set; }

        public string Titulli { get; set; }
        public string Pershkrimi { get; set; }
        public int Sesionet { get; set; }

    }
}
