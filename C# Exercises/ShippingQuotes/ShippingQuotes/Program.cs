using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuotes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("What is the weight of your package?");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the width of your package?");
            }

            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the height of your package?");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the length of your package?");
            double length = Convert.ToDouble(Console.ReadLine());

            double dimensionSum = height + length;
            double quote = (dimensionSum * weight) / 100;

            string dimensionCheck = dimensionSum > 50 ? "Package too big to be shipped via Package Express." : "Your estimated total for shipping this package is: $" + quote;

            Console.WriteLine(dimensionCheck);
            Console.ReadLine();

        }
    }
}
