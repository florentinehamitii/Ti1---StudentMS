using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_BO;
using StudentMS_DAL;

namespace StudentMS_DAL
{
  public  class TeacherDAL
    {
        public bool InsertTeachers(TeacherBO teacherBO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_InsertTeachers", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Emri", teacherBO.Emri);
                    cmd.Parameters.AddWithValue("@Mbiemri", teacherBO.Mbiemri);
                    cmd.Parameters.AddWithValue("Gjinia", teacherBO.Gjinia);
                    cmd.Parameters.AddWithValue("Email", teacherBO.Email);
                    cmd.Parameters.AddWithValue("NumriTelefonit", teacherBO.NumriTelefonit);
                    cmd.Parameters.AddWithValue("Vendbanimi", teacherBO.Vendbanimi);
                    cmd.Parameters.AddWithValue("Specializimi", teacherBO.Specializimi);
                    cmd.Parameters.AddWithValue("WeeklyWorkingHours", teacherBO.WeeklyWorkingHours);
                    cmd.Parameters.AddWithValue("InsertBy", teacherBO.InsertBy);
                    cmd.Parameters.AddWithValue("InsertDate", teacherBO.InsertDate);
                    cmd.Parameters.AddWithValue("LUB", teacherBO.LUB);
                    cmd.Parameters.AddWithValue("LUD", teacherBO.LUD);
                    cmd.Parameters.AddWithValue("LUN", teacherBO.LUN);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
