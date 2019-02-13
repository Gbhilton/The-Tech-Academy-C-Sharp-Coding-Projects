using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Income Comparison Program

            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string person1HourlyRate = Console.ReadLine();
            double person1HourlyWage = Convert.ToInt32(person1HourlyRate);
            Console.WriteLine("Hours worked per week?");
            string person1HoursWorked = Console.ReadLine();
            double person1HoursWorkedWeekly = Convert.ToInt32(person1HoursWorked);
            double person1AnnualSalary = (person1HoursWorkedWeekly * person1HourlyWage) * 52;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string person2HourlyRate = Console.ReadLine();
            double person2HourlyWage = Convert.ToInt32(person2HourlyRate);
            Console.WriteLine("Hours worked per week?");
            string person2HoursWorked = Console.ReadLine();
            double person2HoursWorkedWeekly = Convert.ToInt32(person2HoursWorked);
            double person2AnnualSalary = (person2HoursWorkedWeekly * person2HourlyWage) * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(person1AnnualSalary);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(person2AnnualSalary);

            bool payDifference = person1AnnualSalary > person2AnnualSalary;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(payDifference);
            Console.ReadLine();
        }
    }
}
