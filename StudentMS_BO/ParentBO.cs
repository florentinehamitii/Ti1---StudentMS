using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    public class ParentBO: Base
    {
        public int ParentID { get; set; }
        public string EmriBabit { get; set; }
        public string EmriMamit { get; set; }
        public string Mbiemri { get; set; }
        public string NrTel { get; set; }
        public string Email { get; set; }

    }
}
