using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    public class StudentBO:Base
    {
        public int StudentID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public int PrindiID { get; set; }
        public DateTime DataLindjes { get; set; }
        public string Gjinia { get; set; }
        public string Email { get; set; }
        public string NrTel { get; set; }
        public int KursiID { get; set; }
    }
}
