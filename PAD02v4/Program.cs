using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PAD02v4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Ivan","Ivanov","IT",2000);
            EmployeeRepository empRep = new EmployeeRepository();
            empRep.employees.Add(emp);

            Message msg = new Message(new AvgSalary(2, 2000), empRep);

            BinaryWorker bw = new BinaryWorker();
            byte[] bytes = bw.messageToBytes(msg);

            Message fromBytes = bw.bytesToMessage(bytes);
        }
    }
}
