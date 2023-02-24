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
            Console.WriteLine("\n");
            Console.WriteLine("First and FirstorDefault");
            Console.WriteLine("\n");

            //Where
            List<Employee> filteredEmployees = employees.Where(emp => emp.Job == "Manager").ToList();
            Console.WriteLine(filteredEmployees[0].EmpID + "," + filteredEmployees[0].EmpName);


            //First
            Employee firstManager = employees.First(emp => emp.Job == "Manager");
            Console.WriteLine(firstManager.EmpID + "," + firstManager.EmpName);

            //FirstorDefault
            Employee firstManager2 = employees.FirstOrDefault(emp => emp.Job == "Clerk");
            if (firstManager2!=null)
            {
                Console.WriteLine(firstManager2.EmpID + "," + firstManager2.EmpName);
            }
            else
            {
                Console.WriteLine("No clerk in the list!");
            }

            Console.ReadKey();
        }
    }
}
