using HRMSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.BLL
{
    public class SystemGuard
    {
        public UserType Check(string un, string pwd)
        {
            OperatorService opServ = new OperatorService();
            OperationLogService logServ = new OperationLogService();
            Operator op = opServ.GetOperator(un);
            OperationLog log = new OperationLog();
            log.Id = Guid.NewGuid();
            log.ActionDate = DateTime.Now;

            UserType ut;
            if (op == null)
            {
                log.OperatorId = Guid.Empty;
                log.ActionDesc = "非法登陆，无此用户！！！";
                ut= UserType.NoUser;
            }
            else if(op.Password != pwd)
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "非法登录，密码不正确！！！";
                ut= UserType.PasswordError;
            }
            else if(op.IsDeleted)
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "非法登录，用户已删除！！！";
                ut = UserType.Deleted;
            }
            else if(op.IsLocked)
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "非法登录，用户被锁定！！！";
                ut = UserType.Locked;
            }
            else
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "合法登陆，登陆成功！！！";
                LoginUser lu = LoginUser.GetInstance();
                lu.InitMember(op);
                ut= UserType.ValidUser;
            }
            logServ.Add(log);
            return ut;
        }
    }

    public enum UserType { ValidUser, NoUser, PasswordError,Deleted,Locked}
}
