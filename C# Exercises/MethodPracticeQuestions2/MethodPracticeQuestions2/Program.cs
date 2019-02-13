using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPracticeQuestions2
{
    class Program
    {
        static void Main(string[] args)
        {
           ////1.Create a class. In that class, create a method that takes two integers as parameters.Make one of them optional.Have the method do a math operation and return a integer result.

                 //Done, I added an " = 1" to input2.

            //2. In the Main() method of the console app, instantiate the class.

                 Methods newMethod = new Methods();


            //3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.

            Console.WriteLine("Please input a number:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a second number (Optional, you do not need to enter a number here):");
            string tempinput = Console.ReadLine();

            //4. Call the method in the class, passing in the one or two numbers entered.

            //newMethod.DoubleInput(input1, input2);

            //5. Try various combinations of numbers on the code, including having no second number.

            if (tempinput == null || tempinput == "")
            {
                Console.WriteLine(input1 + " times 2 equals " + newMethod.DoubleInput(input1));
                Console.ReadLine();
            }
            else
            {
                int input2 = Convert.ToInt32(tempinput);
                Console.WriteLine(input1 + " times " + input2 + " equals " + newMethod.DoubleInput(input1, input2));
                Console.ReadLine();
            }

        }
    }
}
