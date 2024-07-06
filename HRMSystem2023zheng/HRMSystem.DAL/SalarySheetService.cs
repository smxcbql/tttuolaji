using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
   public class SalarySheetService
    {

        public Guid GetSalarySheetId(int month, int year, Guid departmentId)
        {
            string sql = "select Id from SalarySheet where Year = @year and Month = @month and DepartmentId = @deptId";
            SqlParameter[] para = {
                new SqlParameter("@year", year),
                new SqlParameter("@month", month),
                new SqlParameter("@deptId", departmentId),
            };
            Object Id = SqlHelper.ExecuteScalar(sql, para);
            if (Id != null)
            {
                return (Guid)Id;
            }
            else
            {
                return Guid.Empty;
            }
        }
        public Guid BuildNewSalarySheet(SalarySheet sheet)
        {
            string sql = "insert into SalarySheet(Id, Year, Month, DepartmentId) values(@Id, @Year, @Month, @DeptId)";
            SqlParameter[] para =
            {
                new SqlParameter("@Id", sheet.Id),
                new SqlParameter("@Year", sheet.Year),
                new SqlParameter("@Month", sheet.Month),
                new SqlParameter("@DeptId", sheet.DepartmentId),
            };
            SqlHelper.ExecuteNonQuery(sql, para);
            return sheet.Id;
        }
       
    }
}
