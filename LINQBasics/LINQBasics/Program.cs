using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBasics
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }

    }
    class Program
    {
        static void Main()
        {
            //collecton of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpID=101,EmpName="Henry",Job="Designer",City="Boston"},
                new Employee(){EmpID=102,EmpName="Jack",Job="Developer",City="New York"},
                new Employee(){EmpID=103,EmpName="Gabriel",Job="Analyst",City="Tokyo"},
                new Employee(){EmpID=104,EmpName="William",Job="Manager",City="Tokyo"},
                new Employee(){EmpID=105,EmpName="Alexa",Job="Manager",City="New York"}
            };

            IEnumerable<Employee> result = employees.Where(emp=>emp.City =="New York");
            foreach (Employee item in result)
            {
                Console.WriteLine(item.EmpID+","+item.EmpName+","+item.Job+","+item.City);
            }

            IOrderedEnumerable<Employee> sortedEmployees =  employees.OrderByDescending(emp => emp.Job)
                .ThenByDescending(emp => emp.EmpName);
            foreach (Employee item in sortedEmployees)
            {
                Console.WriteLine(item.EmpID + "," + item.EmpName + "," + item.Job + "," + item.City);
            }

            Console.ReadKey();
        }
    }
}
