using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program2
    {
        
    }

    public class Page
    {
        public void Login(string empid, string password)
        {
            EmployeeDB employeeDB = new EmployeeDB();
            Employee empolyee = employeeDB.GetEmployee(empid);
            var test = empolyee.Validate(password);
        }
    }

    public class Employee
    {
        public bool Validate(string password)
        {
            return true;
        }
    }

    public class EmployeeDB
    {
        public Employee GetEmployee(string empid)
        {
            Employee e = new Employee();
            return e;
        }
    }
}
