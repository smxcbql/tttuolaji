using HRMSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HRMSystem.BLL
{
  public  class EmptyJudge
    {
        public bool isSheetExist(int month,int year,Guid deptId)
        {
            string sql = "select count(*) from SalarySheet where Year=@year and Month=@month and DepartmentId=@deptId";
            SqlParameter[] para ={
                new SqlParameter("@year",year),
                new SqlParameter("@month",month),
                new SqlParameter("@deptId",deptId),
            };
           
            if((int)SqlHelper.ExecuteScalar(sql,para)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEmployeeExist(Guid depId)
        {
            string sql = "select count(*) from Employee where DepartmentId = @depId";
            SqlParameter para = new SqlParameter("@depId", depId);
            return (int)SqlHelper.ExecuteScalar(sql, para) > 0;
        }
    }
}
