using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD02v4
{
    [Serializable]
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string department;
        public float salary;

        public Employee()
        {
            this.firstName = null;
            this.lastName = null;
            this.department = null;
            this.salary = 0;
        }
        public Employee(string firstName, string lastName, string department, int salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
            this.salary = salary;
        }

        public override string ToString()
        {
            return
                firstName.ToString() + " " +
                lastName.ToString() + " " +
                department.ToString() + " " +
                salary.ToString();
        }

    }
}
