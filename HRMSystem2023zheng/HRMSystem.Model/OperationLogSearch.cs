using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Model
{
   public class OperationLogSearch
    {
        public string Name { get; set; }
        public string RealName { get; set; }
        public bool ExistDate { get; set; }
        public DateTime InDateFrom { get; set; }
        public DateTime InDateTo { get; set; }
    }
}
