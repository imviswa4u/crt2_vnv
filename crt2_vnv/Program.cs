using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_PRA
{
    class PayrollRunner
    {
        static void Main(string[] args)
        {
            // use Employee without tax
            Employee john = new Employee(1, "John Doe", 20000, false);
            john.printInformation();

            // use Employee with tax
            Employee jane = new Employee(2, "Jane Doe", 36000);
            jane.printInformation();

            // use WeeklyEmployee without tax
            WeeklyEmployee jack = new WeeklyEmployee(3, "Jack Deer", 18500, false);
            jack.printInformation();

            // use WeeklyEmployee with tax
            WeeklyEmployee jen = new WeeklyEmployee(4, "Jen Deer", 18000);
            jen.printInformation();

            Console.Read();
        }

        class Employee
        {
            //Private variables
            private int employeeID;
            private String fullName;
            private float salary;
            private bool taxDeducted;

            //Constructor with 4 parameters
            public Employee(int employeeId, String fullName, float salary, bool taxDeducted)
            {
                this.employeeID = employeeId;
                this.fullName = fullName;
                this.salary = salary;
                this.taxDeducted = taxDeducted;
            }
            //Constructor with 3 parameters
            public Employee(int employeeId, String fullName, float salary)
            {
                this.employeeID = employeeId;
                this.fullName = fullName;
                this.salary = salary;
            }
            //Function to calculate total salary after tax deduction if applicable
            public float getNetSalary()
            {
                float sal = this.salary;
                if (this.taxDeducted == true)
                {
                    sal = (float)(sal - (0.2 * sal));
                }
                return sal;
            }
            //Function to display monthly salary
            public void printInformation()
            {
                Console.WriteLine(this.employeeID + ", " + this.fullName + " earns " + getNetSalary() + " per month.");
            }
        }
        class WeeklyEmployee : Employee
        {
            private int employeeID;
            private String fullName;
            private float salary;
            private bool taxDeducted;
            public WeeklyEmployee(int employeeId, String fullName, float salary, bool taxDeducted) : base(employeeId, fullName, salary, taxDeducted)
            {
                this.employeeID = employeeId;
                this.fullName = fullName;
                this.salary = salary;
                this.taxDeducted = taxDeducted;
            }
            public WeeklyEmployee(int employeeId, String fullName, float salary) : base(employeeId, fullName, salary)
            {
                this.employeeID = employeeId;
                this.fullName = fullName;
                this.salary = salary;
            }
            public float getNetSalary()
            {
                float sal = this.salary;
                if (this.taxDeducted == true)
                {
                    sal = (float)(sal - (0.2 * sal));
                }
                return sal / 4;
            }
            public void printInformation()
            {
                Console.WriteLine(this.employeeID + ", " + this.fullName + " earns " + getNetSalary() + " per week.");
            }
        }
    }
}
