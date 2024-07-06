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
  public  class EmployeeService
    {
        public static DataTable GetEmployeeList()
        {
            string sql = "SELECT Id AS 编号,Number as 工号,Name as 姓名,InDay as 入职时间,Nation as 民族,NativePlace as 籍贯 from Employee";
            return SqlHelper.GetTable(sql);
        }
        public DataTable GetEmployeeList(EmployeeSelect es)
        {
            string sql = "SELECT Id AS 编号,Number as 工号,Name as 姓名,InDay as 入职时间,Nation as 民族,NativePlace as 籍贯 from Employee";
            List<SqlParameter> whereParameters = new List<SqlParameter>();
            if(es!=null)
            {
                List<string> wherelist = new List<string>();
                if(!string.IsNullOrEmpty(es.Name))
                {
                    wherelist.Add(string.Format("Name like '%'+ @Name + '%'"));
                    whereParameters.Add(new SqlParameter("@Name", es.Name));
                }
                if(es.TimeCheck)
                {
                    wherelist.Add(string.Format("Inday between @Time1 and @Time2"));
                    whereParameters.Add(new SqlParameter("@Time1", es.Inday1));
                    whereParameters.Add(new SqlParameter("@Time2", es.Inday2));
                }
                if(es.DepartmentId!=Guid.Empty)
                {
                    wherelist.Add(string.Format("DepartmentId = @Dept"));
                    whereParameters.Add(new SqlParameter("@Dept", es.DepartmentId));
                }
                string whereStr = string.Join(" and ", wherelist);
                if(whereStr != null && whereStr.Length>0)
                {
                    sql += " where " + whereStr;
                }
            }
            return SqlHelper.GetTable(sql, whereParameters.ToArray());
        }
        public bool InsertEmployee(Employee emp)
        {
            string sql = "insert into Employee values(@Id, @Number, @Name, @BirthDay, @InDay, @MarriageId, @PartyId, @EducationId, @GenderId, @DepartmentId, @Telephone, @Address, @Email, @Remarks, @Resume, @Photo, @Nation, @NativaPalce)";
            SqlParameter[] Parameter = {
                new SqlParameter("@Id", emp.Id),
                new SqlParameter("@Number", emp.Number),
                new SqlParameter("@Name", emp.Name),
                new SqlParameter("@BirthDay", emp.BirthDay),
                new SqlParameter("@InDay", emp.InDay),
                new SqlParameter("@MarriageId", emp.MarriageId),
                new SqlParameter("@PartyId", emp.PartyId),
                new SqlParameter("@EducationId", emp.EducationId),
                new SqlParameter("@GenderId", emp.GenderId),
                new SqlParameter("@DepartmentId", emp.DepartmentId),
                new SqlParameter("@Telephone", emp.Telephone),
                new SqlParameter("@Address", emp.Address),
                new SqlParameter("@Email", emp.Email),
                new SqlParameter("@Remarks", emp.Remarks),
                new SqlParameter("@Resume", emp.Resume),
                new SqlParameter("@Photo", emp.Photo),
                new SqlParameter("@Nation", emp.Nation),
                new SqlParameter("@NativaPalce", emp.NativePlace),
            };
            return SqlHelper.ExecuteNonQuery(sql, Parameter) > 0;
        }
        public Employee GetEmpById(Guid id)
        {
            string sql = "select * from Employee where Id = @id";
            SqlParameter para = new SqlParameter("@id", id);
            Employee emp = new Employee();
            SqlDataReader sdr = SqlHelper.GetDataReader(sql, para);
            while (sdr.Read())
            {
                emp.Name = sdr["Name"].ToString();
                emp.Address = sdr["Address"].ToString();
                emp.Telephone = sdr["Telephone"].ToString();
                emp.Resume = sdr["Resume"].ToString();
                emp.Remarks = sdr["Remarks"].ToString();
                emp.Photo = (byte[])sdr["Photo"];
                emp.PartyId = (Guid)sdr["PartyId"];
                emp.Number = sdr["Number"].ToString();
                emp.NativePlace = sdr["NativePlace"].ToString();
                emp.Nation = sdr["Nation"].ToString();
                emp.MarriageId = (Guid)sdr["MarriageId"];
                emp.InDay = (DateTime)sdr["InDay"];
                emp.Email = sdr["Email"].ToString();
                emp.EducationId = (Guid)sdr["EducationId"];
                emp.DepartmentId = (Guid)sdr["DepartmentId"];
                emp.BirthDay = (DateTime)sdr["BirthDay"];
                emp.GenderId = (Guid)sdr["GenderId"];
            }
            return emp;
        }
        public bool deleteEmployeeById(Guid id)
        {
            string sql = "delete from Employee where Id = @id";
            SqlParameter param = new SqlParameter("@id", id);
            if (SqlHelper.ExecuteNonQuery(sql, param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateEmployee(Employee emp, Guid id)
        {
            string sql = "update Employee set Number = @Number, Name = @Name, BirthDay = @BirthDay, InDay = @InDay, MarriageId = @MarriageId, PartyId = @PartyId, EducationId = @EducationId, GenderId = @GenderId, DepartmentId = @DepartmentId, Telephone = @Telephone, Address = @Address, Email = @Email, Remarks = @Remarks, Resume = @Resume, Photo = @Photo, Nation = @Nation, NativePlace = @NativaPalce where Id = @Id";
            SqlParameter[] Parameter = {
                new SqlParameter("@Id", id),
                new SqlParameter("@Number", emp.Number),
                new SqlParameter("@Name", emp.Name),
                new SqlParameter("@BirthDay", emp.BirthDay),
                new SqlParameter("@InDay", emp.InDay),
                new SqlParameter("@MarriageId", emp.MarriageId),
                new SqlParameter("@PartyId", emp.PartyId),
                new SqlParameter("@EducationId", emp.EducationId),
                new SqlParameter("@GenderId", emp.GenderId),
                new SqlParameter("@DepartmentId", emp.DepartmentId),
                new SqlParameter("@Telephone", emp.Telephone),
                new SqlParameter("@Address", emp.Address),
                new SqlParameter("@Email", emp.Email),
                new SqlParameter("@Remarks", emp.Remarks),
                new SqlParameter("@Resume", emp.Resume),
                new SqlParameter("@Photo", emp.Photo),
                new SqlParameter("@Nation", emp.Nation),
                new SqlParameter("@NativaPalce", emp.NativePlace),
            };
            return SqlHelper.ExecuteNonQuery(sql, Parameter) > 0;
        }


    }

}
