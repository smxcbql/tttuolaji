using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Model
{
  public class EmployeeSelect
    {
        public string Name { get; set; }
        public DateTime Inday1 { get; set; }
        public DateTime Inday2 { get; set; }
        public Guid DepartmentId { get; set; }
        public bool TimeCheck { get; set; }
    }
}
