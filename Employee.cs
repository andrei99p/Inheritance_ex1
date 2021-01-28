using System;
using System.Collections.Generic;
using System.Text;

namespace Mostenire
{
    class Employee
    {
        protected  string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employee()
        {
            this.Name = "Popescu";
            this.FirstName = "Dragos-Andrei";
        }
        public Employee(string Name, string FirstName, int Salary)
        {
            this.Name = Name;
            this.FirstName = FirstName;
            this.Salary = Salary;
        }

        public Employee(string Name, string FirstName)
        {
            this.Name = Name;
            this.FirstName = FirstName;
        }


        public void Work()
        {
            Console.WriteLine("{0} {1} is now working ", this.Name, this.FirstName);
        }

        public void Pause()
        {
            Console.WriteLine("{0} {1} is now taking a pause ", this.Name, this.FirstName);
        }

        public override string ToString()
        {
            return String.Format("The Employee's name is {0} {1} and has a salary of {2}", this.Name, this.FirstName, this.Salary);
        }
    }
}
