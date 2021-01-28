using System;
using System.Collections.Generic;
using System.Text;

namespace Mostenire
{
    class Boss:Employee
    {
        private string CompanyCar { get; set; }
        

        public Boss()
        {

        }

        public Boss(string Name, string FirstName, int salary):base(Name,FirstName,salary)
        {
            
            this.CompanyCar = "Volkswagen";
            
        }

        public void Lead()
        {
            Console.WriteLine("{0} {1} leads a project now", this.Name, this.FirstName);
        }

        public override string ToString()
        {
            return String.Format("The Boss is named {0} {1}, has a salary of {2} and a {3} car", this.Name, this.FirstName, this.Salary, this.CompanyCar);
        }
    }
}
