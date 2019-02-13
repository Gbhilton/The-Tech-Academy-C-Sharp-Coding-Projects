using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ask the user for his age.

            //Console.WriteLine("What is your age?");
            //int age = Convert.ToInt32(Console.ReadLine());

            //2.Display the year user born.

            //DateTime currentDate = DateTime.Now;
            //DateTime dateUseBorn = currentDate.AddYears(-age);
            //int yearUserWasBorn = dateUseBorn.Year;
            //Console.WriteLine("Your were born in " + yearUserWasBorn + ".");
            //Console.ReadLine();

            //3.Exceptions must be handled using "try .. catch".
            //4.Display appropriate error messages if user enters zero or negative numbers.
            //5.Display a general message if exception caused by anything else.

            try
            {
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new InvalidNumberExceptions();
                }
                DateTime currentDate = DateTime.Now;
                DateTime dateUseBorn = currentDate.AddYears(-age);
                int yearUserWasBorn = dateUseBorn.Year;
                Console.WriteLine("Your were born in " + yearUserWasBorn + ".");
                Console.ReadLine();
            }
            catch (InvalidNumberExceptions)
            {
                Console.WriteLine("Please enter a valid number (cannot be negative or zero)");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error. Please report to the System Admin.");
                Console.ReadLine();
                return;
            }

            



        }
    }
}
