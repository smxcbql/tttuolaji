using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.DAL
{
   public class DepartmentService
    {
        public DataTable GetAllDepartments()
        {
            string sql = "select * from Department";
            return SqlHelper.GetTable(sql);
        }
        public static string Search(string name)
        {
            string Dname = null;
            string sql = "SELECT Department.Name FROM Employee,Department WHERE (Employee.DepartmentId=Department.Id AND Employee.Name=@Name)";
            SqlParameter parameterName = new SqlParameter("@Name", name);
            SqlDataReader sdr = SqlHelper.GetDataReader(sql, parameterName);
                if (sdr.Read())
                {
                    Dname = sdr["Name"].ToString();
                }
            return Dname;
        }
        public static Guid GetDeId(string Dname)//根据工作名称找到工作id
        {

            Guid g = new Guid();
           
            string sql = "SELECT Id FROM Department WHERE Name=@Name";
            SqlParameter paraName = new SqlParameter("@Name", Dname);
            SqlDataReader dr = SqlHelper.GetDataReader(sql, paraName);
                if (dr.Read())
                {
                    g = (Guid)dr["Id"];
                }
            
            return g;
        }
        public static void Change(string name, string Dname)
        {
            Guid deid = DepartmentService.GetDeId(Dname);
            string oldename = DepartmentService.Search(name);
            string sql = "UPDATE  Employee SET DepartmentId=@DeId WHERE  Name=@Name";
            SqlParameter paraDeId = new SqlParameter("@DeId", deid);
            SqlParameter paraName = new SqlParameter("@Name", name);
            int n = SqlHelper.ExecuteNonQuery(sql, paraDeId, paraName);
                if (n > 0)
                {
                    string s = string.Format("更改成功！员工{0}将从{1}更改到{2}", name, oldename, Dname);
                    MessageBox.Show(s);
                }
        }
    
}
}
