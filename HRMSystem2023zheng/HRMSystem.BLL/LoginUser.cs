using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.BLL
{
   public class LoginUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }
        public bool IsAdmin { get; set; }
        public static LoginUser lu = null;
        private LoginUser() { }
        public static LoginUser GetInstance()
        {
            if(lu==null)
            {
                lu = new LoginUser();
            }
            return lu;
        }
        public void InitMember(Operator op)
        {
            Id = op.Id;
            RealName = op.RealName;
            IsAdmin = op.IsAdmin;
            UserName = op.UserName;
            Password = op.Password;
        }
    }
}
