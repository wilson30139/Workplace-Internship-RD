using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Page page = new Page();
            page.Login("123456", "123Eric");
        }
    }

    public class Page
    {
        public void Login(string empid, string password)
        {
            EmployeeDB employeeDB = new EmployeeDB();
            employeeDB.GetEmployee(empid);
            Employee employee = new Employee();
            var test = employee.Validate(password);
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
