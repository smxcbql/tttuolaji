using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
  public  class SalarySheetItemService
    {
        public void BuildSalarySheetItems(Guid sheetId, Guid deptId)
        {
            string sql1 = "select Id from Employee where DepartmentId = @deptId";
            string sql2 = "insert into SalarySheetItem(Id, SheetId, EmployeeId, BaseSalary, Bonus, Fine, Other) values(@Id, @SheetId, @EmployeeId, 0, 0, 0, 0)";
            SqlParameter parameter = new SqlParameter("@deptId", deptId);
            SqlDataReader sdr = SqlHelper.GetDataReader(sql1, parameter);

            while (sdr.Read())
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Id", Guid.NewGuid()),
                    new SqlParameter("@SheetId", sheetId),
                    new SqlParameter("@EmployeeId", sdr["Id"]),
                };
                SqlHelper.ExecuteNonQuery(sql2, para);

            }
        }
        public DataTable GetSalarySheetItems(Guid sheetId)
        {
            string sql = "select SalarySheetItem.Id as 编号, Employee.Name as 姓名, SalarySheetItem.BaseSalary as 基本工资, SalarySheetItem.Bonus as 奖金, SalarySheetItem.Fine as 罚款, SalarySheetItem.Other as 其他 from SalarySheetItem, Employee where SheetId = @sheetId and SalarySheetItem.EmployeeId = Employee.Id";
            SqlParameter para = new SqlParameter("@sheetId", sheetId);
            return SqlHelper.GetTable(sql, para);
        }
        public void ReBuildSalarySheetItem(Guid sheetId)
        {
            string sql = "update SalarySheetItem set BaseSalary = 0, Bonus = 0, Fine = 0, Other = 0 where SheetId = @sheetId";
            SqlParameter para = new SqlParameter("@sheetId", sheetId);
            SqlHelper.ExecuteNonQuery(sql, para);
        }
        public void SaveSheetItem(SalarySheetItem sheetitem)
        {
            string sql = "update SalarySheetItem set BaseSalary = @base, Bonus = @bonus, Fine = @fine, Other = @other where Id = @id";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@base", sheetitem.BaseSalary),
                new SqlParameter("@bonus", sheetitem.Bonus),
                new SqlParameter("@fine", sheetitem.Fine),
                new SqlParameter("@other", sheetitem.Other),
                new SqlParameter("@id", sheetitem.Id),
            };
            SqlHelper.ExecuteNonQuery(sql, para);
        }
        public DataTable GetReportSheet(Guid sheetId)
        {
            string sql = "select SalarySheet.Year as year,SalarySheet.Month as month,Department.Name as dept,SalarySheetItem.Id ,Employee.Name as name ,BaseSalary as baseSalary ,Bonus as bonus,Fine as fine ,Other as other from SalarySheetItem ,Employee,SalarySheet ,Department where SheetId=@SheetId and SalarySheetItem.EmployeeId=Employee.Id and SalarySheetItem.SheetId=SalarySheet.Id and SalarySheet.DepartmentId=Department.Id";
            SqlParameter para = new SqlParameter("@SheetId", sheetId);
            return SqlHelper.GetTable(sql, para);
        }
       
    }
}
