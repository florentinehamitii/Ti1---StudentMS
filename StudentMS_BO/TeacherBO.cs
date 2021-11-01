using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    class TeacherBO:Base
    {
        public int TeacherID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Gjinia { get; set; }
        public string Email { get; set; }
        public string NumriTelefonit { get; set; }
        public string Vendbanimi { get; set; }
        public string Specializimi { get; set; }
        public int WeeklyWorkingHours { get; set; }
        
        StudentBO student;//per me e lidh teachirn me studenta
    }
}
