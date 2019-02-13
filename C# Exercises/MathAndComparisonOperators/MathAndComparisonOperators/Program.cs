using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 10 + 5;
            int combined = total + 22;
            Console.WriteLine("The total of the combined numbers is: " + combined);
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine("Ten minus 5 is: " + difference);
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            double quotient = 10.0 / 7.0;
            Console.WriteLine(quotient);
            Console.ReadLine();

            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 72;

            bool isWarm = currentTemperature >= roomTemperature;
            bool isWarm = currentTemperature == roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();

        }
    }
}
