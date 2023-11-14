using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KellyHumphrey_usearray
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Employee[] employees = Employee.GetEmployeeData();
            Console.WriteLine(Employee.EmployeeReportTitle("Employee Report Data Dump"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("\n");
            Console.WriteLine(Employee.EmployeeReportTitle("Employees with less than 1 Year of Service"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees)
            {
                if (employee.YearsOfService() < 1.00)
                {
                    Console.WriteLine(employee);
                }
                    
            }

            Console.WriteLine("\n");
            Console.WriteLine(Employee.EmployeeReportTitle("Employees with 1 to 5 Years of Service"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees)
            {
                if (employee.YearsOfService() > 1.00 && employee.YearsOfService() < 5)
                {
                    Console.WriteLine(employee);
                }

            }

            Console.WriteLine("\n");
            Console.WriteLine(Employee.EmployeeReportTitle("Employees with 6 to 10 Years of Service"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees)
            {
                if (employee.YearsOfService() > 6.00 && employee.YearsOfService() < 10)
                {
                    Console.WriteLine(employee);
                }

            }

            Console.WriteLine("\n");
            Console.WriteLine(Employee.EmployeeReportTitle("Employees with more than 10 Years of Service"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees)
            {
                if (employee.YearsOfService() > 10.00)
                {
                    Console.WriteLine(employee);
                }

            }


            Console.WriteLine("\n");
            Console.WriteLine(Employee.EmployeeReportTitle("Employees sorted by Employement Status"));
            Console.WriteLine(Employee.ColumnHeader());
            Employee[] SortedEmployees = employees.OrderBy(Employee => Employee.getEmpStatus()).ToArray();
            foreach (Employee employee in SortedEmployees)
            {
                Console.WriteLine(employee);
            }



            Console.WriteLine("\nHit any key to continue...");
            Console.ReadKey();

            
        }
    }
}
