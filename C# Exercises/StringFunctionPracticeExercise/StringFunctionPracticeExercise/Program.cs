using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionPracticeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string hobby = "Video Games";
            string name = "Grant";
            string car = "Hyundai";
            car = car.ToUpper();

            //Console.WriteLine("Hi, my name is " + name + ", and I drive a " + car + " and play " + hobby + "!");
            //Console.ReadLine();

            StringBuilder grantsb = new StringBuilder();

            grantsb.Append("Hi, my name is " + name + ". I am from Jacksonville, FL but now I live in Connecticut, and this place is awful. ");

            Console.WriteLine(grantsb);
            Console.ReadLine();

            car = "Hyundai";
            grantsb.Append("I drove over 1000 miles from Jacksonville to Norwalk in my " + car + " and my legs almost fell off. ");

            Console.WriteLine(grantsb);
            Console.ReadLine();

            grantsb.Append("However I knew that once I got here I could indulge in some " + hobby + " all I wanted, so that kept me sane.");

            Console.WriteLine(grantsb);
            Console.ReadLine();
        }
    }
}
