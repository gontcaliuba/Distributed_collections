using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD02v4
{
    [Serializable]
    public class MessageCalc
    {
        public EmployeeRepository sortedEl = new EmployeeRepository();
        public EmployeeRepository filteredEl = new EmployeeRepository();
        public List<EmployeeRepository> groupedEl = new List<EmployeeRepository>();
        public MessageCalc(EmployeeRepository sortedEl, EmployeeRepository filteredEl, List<EmployeeRepository> groupedEl)
        {
            this.sortedEl = sortedEl;
            this.filteredEl = filteredEl;
            this.groupedEl = groupedEl;
        }

    }
}
