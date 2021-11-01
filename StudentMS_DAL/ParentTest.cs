using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_DAL
{
   public class ParentTest
    {

        public DataTable GetAllParents()
        {
            try
            {
                using (DatabaseConnection.conn = new SqlConnection(DatabaseConnection.connString))
                {
                    DatabaseConnection.da = new SqlDataAdapter("procedure_name", DatabaseConnection.conn);
                    DataTable dTable = new DataTable();
                    DatabaseConnection.da.Fill(dTable);
                    return dTable;

                }
                    
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
