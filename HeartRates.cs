using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetHeartRateCalc
{
    class HeartRates
    {
        private string firstName;
        private string lastName;
        private int yearOfBirth;

        private int ageInYears;
        private int maximumRate;
        
        // constructor with parameters
        public HeartRates(string firstname, string lastname, int yearofbirth)
        {
            DateTime thisyear = DateTime.Today;
            firstName = firstname;
            lastName = lastname;
            yearOfBirth = yearofbirth;
        }

        // firstname property
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        // last name property
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        // birth year property
        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                yearOfBirth = value;
            }
        }

        // return age in years
        public int AgeInYears
        {
            get
            {
                DateTime todaysDate = DateTime.Today;
                ageInYears = todaysDate.Year - YearOfBirth;
                return ageInYears;
            }
        }

        // return maximum heart rate
        public int MaximumRate
        {
            get
            {
                maximumRate = 220 - ageInYears;
                return maximumRate;
            }
        }

        // display the minimum and maximum heart rates
        public void CalculateMinMaxHeartRate(int maximumrate)
        {
                double minRate, maxRate;
                minRate = maximumrate * .5;
                maxRate = maximumrate * .85;
                Console.WriteLine($"Your target heart rate is {minRate} to {maxRate}");
        }
        



    }

    
}
