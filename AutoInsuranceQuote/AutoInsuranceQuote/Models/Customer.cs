using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoInsuranceQuote.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUI { get; set; }
        public int SpeedingTicket { get; set; }
        public string FullCoverage { get; set; }
        public int Quote { get; set; }

        public double GetQuote()
        {
            //Start with a base of $50 / month.
            double baseQuote = 50;
            double ageQuote = 0;
            double carYearQuote = 0;
            double carMakeQuote = 0;
            double carModelQuote = 0;
            double duiQuote = 0;
            double speedingTicketsQuote = 0;
            double fullCoverageQuote = 0;
            double quote = 0;
            int age = DateTime.Now.Year - DateOfBirth.Year;

            //If the user is under 25, add $25 to the monthly total.
            if (age < 25)
            {
                ageQuote = baseQuote + 25;
            }
            //If the user is under 18, add $100 to the monthly total.
            else if (age < 18)
            {
                ageQuote = baseQuote + 100;
            }
            //If the user is over 100, add $25 to the monthly total.
            else if (age > 100)
            {
                ageQuote = baseQuote + 25;
            }
            //The remainder of the people will be placed into this category.
            else
            {
                ageQuote = baseQuote;
            }

            //If the car's year is before 2000, add $25 to the monthly total.
            //If the car's year is after 2015, add $25 to the monthly total.
            if (CarYear < 2000 || CarYear > 2015)
            {
                carYearQuote = ageQuote + 25;
            }
            else
            {
                carYearQuote = ageQuote;
            }

            //If the car's Make is a Porsche, add $25 to the price.
            if (CarMake == "Porsche")
            {
                carMakeQuote = carYearQuote + 25;
            }
            else
            {
                carMakeQuote = carYearQuote;
            }

            //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
            if (CarMake == "Porsche" && CarModel == "911 Carrera")
            {
                carModelQuote = carMakeQuote + 25;
            }
            else
            {
                carModelQuote = carMakeQuote;
            }

            //Add $10 to the monthly total for every speeding ticket the user has.
            if (SpeedingTicket == 0)
            {
                speedingTicketsQuote = carModelQuote;
            }
            else
            {
                speedingTicketsQuote = carModelQuote + (SpeedingTicket * 10);
            }

            //If the user has ever had a DUI, add 25 % to the total.
            if (DUI == "1")
            {
                duiQuote = speedingTicketsQuote + 25;
            }
            else
            {
                duiQuote = speedingTicketsQuote;
            }

            //If it's full coverage, add 50% to the total.
            if (FullCoverage == "1")
            {
                fullCoverageQuote = duiQuote + (duiQuote * .5);
            }
            else
            {
                fullCoverageQuote = duiQuote;
            }

            quote = fullCoverageQuote;

            return quote;
        }
    }


}