using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_DAL;
namespace StudentMS_BLL
{
   public class ParentBLL
    {
        ParentTest parent;
        public ParentBLL()
        {
            parent = new ParentTest();
        }
        public DataTable ShowAllParent()
        {
            return parent.GetAllParents();
        }
    }
}
