using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.models
{
    internal class EmployeeTask
    {
        public Guid ID { get; set; }
        public string EmployeeName { get; set; }
        public string PerformTask { get; set; }
    }
}
