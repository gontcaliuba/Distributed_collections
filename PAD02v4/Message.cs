using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD02v4
{
[Serializable]
    public class Message
    {
        public AvgSalary s;
        public EmployeeRepository empRep;
        public Message(AvgSalary s, EmployeeRepository empRep)
        {
            this.s = s;
            this.empRep = empRep;
        }
    }
}
