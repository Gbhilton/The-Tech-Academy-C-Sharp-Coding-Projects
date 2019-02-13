using System;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What course are you in?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            String coursePageNumberTemp = Console.ReadLine();
            int coursePageNumber = Convert.ToInt32(coursePageNumberTemp);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string helpNeededTemp = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(helpNeededTemp);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedbackGiven = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursWorkedTemp = Console.ReadLine();
            byte hoursWorked = Convert.ToByte(hoursWorkedTemp);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        
        }
    }
}
