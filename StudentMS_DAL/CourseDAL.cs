using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_BO;
using System.Data.SqlClient;
using StudentMS_BO;
namespace StudentMS_DAL
{
  public  class CourseDAL
    {
        public bool InsertCourses(CourseBO coursesBO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_InsertCourses", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Titulli", coursesBO.Titulli);
                    cmd.Parameters.AddWithValue("@Sessionet", coursesBO.Sesionet);
                    cmd.Parameters.AddWithValue("@InsertBy", coursesBO.InsertBy);
                    cmd.Parameters.AddWithValue("@InsertDate", coursesBO.InsertDate);

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
