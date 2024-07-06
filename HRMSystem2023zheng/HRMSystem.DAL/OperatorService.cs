using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class OperatorService
    {
        public Operator GetOperator(string un)
        {
            Operator op = null;
           
            string sql = string.Format("SELECT * FROM Operator WHERE UserName = @UserName");
            SqlParameter paraUserName = new SqlParameter("@UserName", un);
            SqlDataReader sdr = SqlHelper.GetDataReader(sql, paraUserName);
          
                if (sdr.Read())
                {
                    op = new Operator();
                    op.Id = (Guid)sdr["Id"];
                    op.UserName = sdr["UserName"].ToString();
                    op.Password = sdr["Password"].ToString();
                    op.RealName = sdr["RealName"].ToString();
                    op.IsDeleted = (bool)sdr["IsDeleted"];
                    op.IsLocked = (bool)sdr["IsLocked"];
                    op.IsAdmin = (bool)sdr["IsAdmin"];
                }
            sdr.Close();

            return op;
        }
        public bool InsertOperator(string RealName, string Password, string UserName)
        {
            string sql = "INSERT INTO Operator(Id, UserName, Password, IsDeleted, RealName, IsLocked) VALUES(NEWID(), @UserName, @Password, 0, @RealName, 0)";
            SqlParameter[] parames = {
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@Password", Password),
                new SqlParameter("@RealName", RealName)
            };
            int n = SqlHelper.ExecuteNonQuery(sql, parames);
            return n > 0;
        }
        public bool DeleteOperator(string UserName)
        {
            string sql = "UPDATE Operator SET IsDeleted = 1 WHERE @UserName = UserName";
            SqlParameter paramUserName = new SqlParameter("@UserName", UserName);
            int n = SqlHelper.ExecuteNonQuery(sql, paramUserName);
            return n > 0;
        }
        public bool LockOperator(string UserName)
        {
            string sql = "UPDATE Operator SET IsLocked = 1 WHERE @UserName = UserName";
            SqlParameter paramUserName = new SqlParameter("@UserName", UserName);
            int n = SqlHelper.ExecuteNonQuery(sql, paramUserName);
            return n > 0;
        }
        public void PwdModify(string un, string pwdAfter)
        {
            string sql = "update Operator set Password = @PasswordAfter where UserName = @UserName";
            SqlParameter[] parames = {
                new SqlParameter("@PasswordAfter", pwdAfter),
                new SqlParameter("@UserName", un)
            };
            int n = SqlHelper.ExecuteNonQuery(sql, parames);
        }
    }
}
