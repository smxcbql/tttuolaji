using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
   public class DictService
    {
        public DataTable GetComboList(string para)
        {
            string sql = "select * from Dictionary where Category = @para";
            SqlParameter param = new SqlParameter("@para", para);
            return SqlHelper.GetTable(sql, param);
        }

    }
}
