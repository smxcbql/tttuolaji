using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
   public class OperationLogService
    {
        public DataTable GetAllName()
        {
            
            string sql = "select * from Operator";
            return SqlHelper.GetTable(sql);
        
    }
        public bool Add(OperationLog log)
        {
           
            string sql = "INSERT INTO OperationLog VALUES(@Id,@OperatorId,@ActionDate,@ActionDesc)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id",log.Id),
                new SqlParameter("@OperatorId",log.OperatorId),
                new SqlParameter("@ActionDate",log.ActionDate),
                new SqlParameter("@ActionDesc",log.ActionDesc)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;

        }
        public DataTable GetOperationLogList(int pageNo,int numPerPage)
        {
           
            string sql = "SELECT Temp.Id AS 编号,Operator.RealName AS 操作员,Temp.ActionDate AS 操作时间,Temp.ActionDesc AS 描述 FROM (SELECT TOP (@LogNum) * FROM OperationLog WHERE Id NOT IN (SELECT TOP (@BeforeNum) Id FROM OperationLog)) AS Temp,Operator WHERE Temp.OperatorId = Operator.Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@LogNum", numPerPage),
                new SqlParameter("@BeforeNum", (pageNo - 1) * numPerPage)
            };

            return SqlHelper.GetTable(sql, parameters);

        }
        public DataTable GetOperationLogList(OperationLogSearch ols)
        {
            string sql = "SELECT OperationLog.Id AS 编号,RealName AS 操作员,ActionDate AS 操作时间,ActionDesc AS 描述 FROM OperationLog,Operator where OperationLog.OperatorId = Operator.Id";
            List<SqlParameter> whereParameters = new List<SqlParameter>();
            if (ols != null)
            {
                List<string> whereList = new List<string>();
                if (!string.IsNullOrEmpty(ols.RealName))
                {
                    whereList.Add(string.Format("RealName=@Name"));
                    whereParameters.Add(new SqlParameter("@Name", ols.RealName));
                }
                if (ols.ExistDate)
                {
                    whereList.Add(string.Format("ActionDate between @DateFrom and @DateTo"));
                    whereParameters.Add(new SqlParameter("@DateFrom", ols.InDateFrom));
                    whereParameters.Add(new SqlParameter("@DateTo", ols.InDateTo));
                }
                string whereStr = string.Join(" and ", whereList);
                if (whereStr != null && whereStr.Length > 0)
                {
                    sql += " and " + whereStr;
                }
            }
            return SqlHelper.GetTable(sql, whereParameters.ToArray());
        }
        public int GetLogCount()
        {
            string sql = "SELECT COUNT(*) FROM OperationLog";
            return (int)SqlHelper.ExecuteScalar(sql);
          
        }
        public static bool MoveData(DateTime dt)
        {
            string sql1 = "insert into OprationLogBackup(Id, OperatorId, ActionDate, ActionDesc)(select Id, OperatorId, ActionDate, ActionDesc from OperationLog where ActionDate <= @date)";
            string sql2 = "delete from OperationLog where ActionDate <= @date";
            
            SqlParameter parameters = new SqlParameter("@date", dt);
            if (SqlHelper.Execute(sql1, sql2, parameters))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
