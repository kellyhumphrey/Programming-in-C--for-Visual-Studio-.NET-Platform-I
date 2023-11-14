using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KellyHumphrey_usearray
{
    public class Employee
    {
        private int EmpNumber;
        private string EmpName;
        private EmploymentStatus EmpStatus;
        private decimal HourlyWage;
        private DateTime HireDate;

        public Employee(int empNumber, string empName, EmploymentStatus empStatus, decimal hourlyWage, DateTime hireDate)
        {
            EmpNumber = empNumber;
            EmpName = empName;
            EmpStatus = empStatus;
            HourlyWage = hourlyWage;
            HireDate = hireDate;
        }

        public enum EmploymentStatus
        {
            FullTime,
            PartTime,
            Seasonal,
            Unknown
        };

        public static Employee[] GetEmployeeData()
        {
            var Employees = new Employee[]
            {
                 new Employee(101, "Amie Lee",
                 EmploymentStatus.PartTime, 10.62M,
                 DateTime.Parse("10/13/2008")),
                 new Employee(351, "William Gates",
                 EmploymentStatus.FullTime, 18.94M,
                 DateTime.Parse("2/28/2008")),
                 new Employee(403, "Juan Gomez",
                 EmploymentStatus.Seasonal, 11.48M,
                 DateTime.Parse("11/21/2007")),
                 new Employee(21, "Jesse James",
                 EmploymentStatus.PartTime, 10.62M,
                 DateTime.Parse("3/6/2016")),
                 new Employee(35, "Jalen Rose",
                 EmploymentStatus.FullTime, 18.94M,
                 DateTime.Parse("2/28/2007")),
                 new Employee(345, "Sam Jones",
                 EmploymentStatus.Unknown, 12.48M,
                 DateTime.Parse("9/12/2015")),
                 new Employee(24835, "Karen Lott",
                 EmploymentStatus.PartTime, 16.05M,
                 DateTime.Parse("2/29/1996"))
            };
            return Employees;
        }

        public override string ToString()
        {
            return EmpNumber + "\t" + " ".PadRight(3) + EmpName + " ".PadLeft(5) + "\t" + EmpStatus + "\t" + " ".PadLeft(3) + HourlyWage + "\t" + " ".PadLeft(3) + HireDate + "\t" + " ".PadLeft(3) + Math.Round(YearsOfService(), 2);

        }

        public static string EmployeeReportTitle(string rptTitle)
        {
            return String.Format(rptTitle +
                "\nReport Date: {0:dddd, MMMM d, yyyy}\n\n", GlobalVars.reportDate);
        }

        public static string ColumnHeader()
        {
            return "Employee" + " ".PadLeft(3) + "Name" + " ".PadLeft(16) + "Status" + " ".PadLeft(11) + "Wage" + " ".PadLeft(7) + "Hire Date" + " ".PadLeft(2) + "Years of Service\n" +
                "________" + " ".PadLeft(3) + "____" + " ".PadLeft(16) + "______" + " ".PadLeft(11) + "____" + " ".PadLeft(7) + "_________" + " ".PadLeft(2) + "________________";
        }

        public double YearsOfService()
        {
            double TotalDays = GlobalVars.reportDate.Subtract(this.HireDate).TotalDays;
            double ExactYears = TotalDays / 365;
            return ExactYears;
        }

        public EmploymentStatus getEmpStatus()
        {
            return this.EmpStatus;
        }

    }
}
