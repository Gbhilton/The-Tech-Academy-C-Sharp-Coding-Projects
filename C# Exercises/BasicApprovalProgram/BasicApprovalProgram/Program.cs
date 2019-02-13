using System;

namespace BasicApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?");
            string duiString = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTicketsString = Console.ReadLine();

            int age = Convert.ToInt32(ageString);
            int speedingTickets = Convert.ToInt32(speedingTicketsString);
            bool dui = Convert.ToBoolean(duiString);
            bool isQualified = age > 15 && dui == false && speedingTickets < 4;

            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
