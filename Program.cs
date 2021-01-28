using System;

namespace Mostenire
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee("Aaron", "Page", 2000);
            person1.Work();
            person1.Pause();
            Console.WriteLine(person1.ToString()); 

            Boss person2 = new Boss("Sasha", "Baron", 5000);
            person2.Lead();
            Console.WriteLine(person2.ToString());

            Trainees person3 = new Trainees("Jerry", "Marcus", 25, 30);
            person3.Learn();
            person3.Work();
            Console.WriteLine(person3.ToString());
            
            Console.ReadLine();
        }
    }
}
