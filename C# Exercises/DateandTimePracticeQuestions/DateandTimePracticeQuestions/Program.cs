﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateandTimePracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Date/Time examples of how to write them.
            //DateTime dateOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime dateOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);
            //TimeSpan ageAtGraduation = dateOfGraduation - dateOfBirth;

            //DateTime.Now gives the exact current date/time. Helpful in logging to show when exactly something happened in the log.
            //Console.WriteLine(DateTime.Now);
            //Console.ReadLine();

            //1.Prints the current date and time to the console.

            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            //2.Asks the user for a number.

            Console.WriteLine("Please enter a number below: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

            DateTime currentTime = DateTime.Now;
            DateTime laterTimeByUser = currentTime.AddHours(number);
            Console.WriteLine("The time in {0} hours will be " + laterTimeByUser, number);
            Console.ReadLine();
        }
    }
}