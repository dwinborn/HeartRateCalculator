using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetHeartRateCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables to be passed into constructor when object is created
            string fname, lname;
            int birthyear;

            // prompt for first name
            Console.WriteLine("Enter your first name: ");
            fname = Console.ReadLine();

            // prompt for last name
            Console.WriteLine("Enter your last name: ");
            lname = Console.ReadLine();

            // prompt for birthyear
            Console.WriteLine("Enter your birthyear: ");
            birthyear = int.Parse(Console.ReadLine());

            // instantiate object of class heartrate
            // pass values collect to constructor
            HeartRates person1 = new HeartRates(fname, lname, birthyear);

            // display results, name, age, max and target heart rates
            Console.WriteLine($"Name: {person1.FirstName} {person1.LastName}");
            Console.WriteLine($"Age: {person1.AgeInYears}");
            Console.WriteLine($"Your maximum heart rate is {person1.MaximumRate}");
            person1.CalculateMinMaxHeartRate(person1.MaximumRate);
            Console.ReadLine();
        }
    }
}
