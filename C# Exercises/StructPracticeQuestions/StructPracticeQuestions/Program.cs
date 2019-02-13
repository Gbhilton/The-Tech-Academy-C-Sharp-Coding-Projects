using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a struct called Number and give it the property "Amount" and have it be of data type decimal.

            //Created a struct.

            //2. In the Main() method, create an object of data type Number and assign an amount to it.

            Number newNumber = new Number();
            newNumber.Amount = 65;

            //3. Print this amount to the console.

            Console.WriteLine(newNumber.Amount);
            Console.ReadLine();
        }
    }
}
