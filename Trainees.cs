using System;
using System.Collections.Generic;
using System.Text;

namespace Mostenire
{
    class Trainees:Employee
    {
        private int WorkingHours { get; set; }
        private int SchoolHours { get; set; }

        public Trainees()
        {

        }

        public Trainees(string Name, string FirstName, int WorkingHours, int SchoolHours):base(Name,FirstName)
        {
            this.WorkingHours = WorkingHours;
            this.SchoolHours = SchoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("{0} {1} is now learning",this.Name, this.FirstName);
        }

        public void Work()
        {
            Console.WriteLine("{0} {1} works only {2} hours a week", this.Name, this.FirstName, this.WorkingHours);
        }

        public override string ToString()
        {
            return String.Format("{0} {1} is a trainee. He works {2} hours a week and studies {3} hours a week", this.Name, this.FirstName, this.WorkingHours, this.SchoolHours);
        }


    }
}
