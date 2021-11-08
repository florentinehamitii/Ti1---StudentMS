using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StudentMS_BO
{
    public class TeacherBO:Base
    {
        public TeacherBO() { }//konstruktori pa parametra
        public TeacherBO(/*byte[] i,*/string E, string M, string Gj, string Em, string Nr, string V, string S, int W)
        {
           // TeacherIMG = i;
            Emri = E;
            Mbiemri = M;
          //  Gjinia = Gj;
            Email = Em;
            NumriTelefonit = Nr;
         //   Vendbanimi = V;
          //  Specializimi = S;
            WeeklyWorkingHours = W;
        }

        public TeacherBO(string e, string m, string em, string nr, int op)
        {
            Emri = e;
            Mbiemri = m;
            Email = em;
            NumriTelefonit = nr;
            WeeklyWorkingHours = op;
        }

        public int TeacherID { get; set; }
        public byte[] TeacherIMG{ get; set; }
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
