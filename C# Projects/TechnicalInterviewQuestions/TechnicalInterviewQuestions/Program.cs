using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Given an array of integers, write a method to total the odd numbers.

            int[] intArray = new int[] { 45, 65, 45634, 3456, 233332 };
            int sum = 0;
            int i;

            for (i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 != 0)
                {
                    sum = sum + intArray[i];
                }

            }
            Console.WriteLine(sum);
            Console.ReadLine();

            //Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.

            int[] intArray = new int[] { 45, 65, 45634, 3456, 233332 };
            double sum = intArray.Sum();
            Console.WriteLine(sum);
            Console.ReadLine();

            //Given a string, reverse it.

            string newString = "Grant";
            char[] newArray = newString.ToCharArray();
            Array.Reverse(newArray);
            Console.WriteLine(newArray);
            Console.ReadLine();


            //Given a string, remove any repeated letters.

            string newString = "Grant Hilton";
            char[] distinctString = newString.ToCharArray().Distinct().ToArray();
            Console.WriteLine(distinctString);
            Console.ReadLine();

            //FizzBuzz(Look this one up and try it out)

            int i;

            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

        }
    }
}
