using System;

namespace MathExercise1
{
    class Program
    {
        static void Main()
        {
            //1.
            Console.WriteLine("Insert any number.");
            string numberEnteredTemp = Console.ReadLine();
            int numberEntered = Convert.ToInt32(numberEnteredTemp);
            Console.WriteLine("This number times 50 is: " + (numberEntered * 50));
            Console.ReadLine();

            //2.
            Console.WriteLine("Insert any number.");
            string numberEnteredTemp = Console.ReadLine();
            int numberEntered = Convert.ToInt32(numberEnteredTemp);
            Console.WriteLine("This number plus 25 is: " + (numberEntered + 25));
            Console.ReadLine();

            //3.
            Console.WriteLine("Insert any number.");
            string numberEnteredTemp = Console.ReadLine();
            double numberEntered = Convert.ToDouble(numberEnteredTemp);
            Console.WriteLine("This number divided by 12.5 is: " + (numberEntered / 12.5));
            Console.ReadLine();

            //4.
            Console.WriteLine("Insert any number.");
            string numberEnteredTemp = Console.ReadLine();
            int numberEntered = Convert.ToInt32(numberEnteredTemp);
            bool isGreaterThan50 = numberEntered > 50;
            Console.WriteLine(isGreaterThan50);
            Console.ReadLine();

            //5.
            Console.WriteLine("Insert any number.");
            string numberEnteredTemp = Console.ReadLine();
            int numberEntered = Convert.ToInt32(numberEnteredTemp);
            int remainder = numberEntered % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
