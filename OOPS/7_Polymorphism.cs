using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPS
{
    class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void FullName()
        {
            Console.WriteLine(FirstName +" "+LastName);
        }
    }

    class FullTime : Employee
    {
        public override void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName+ " - FTE");
        }
    }

    class PartTime: Employee
    {
        public override void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName+ " - PTE");
        }
    }

    class TempEmploye : Employee
    {
        public override void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName+ " - TEMP");
        }
    }

    class Pract
    {
        public static void Main90()
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTime();
            employees[2] = new PartTime();
            employees[3] = new TempEmploye();

            foreach(Employee employee in employees)
            {
                employee.FullName();
            }
        }
    }
}
