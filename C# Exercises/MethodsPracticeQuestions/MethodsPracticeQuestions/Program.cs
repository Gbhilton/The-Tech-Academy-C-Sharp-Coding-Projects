using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPracticeQuestions
{
        class Program
    {

            //1. Create a class. In that class, create three methods, each of which will take one integer parameter in and 
            //return an integer.The methods should do some math operation on the received parameter.Put this class in a separate.cs file 
            //in the application.

            //2. In the Main() program, ask the user what number they want to do the math operations on.

            //3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

            static void Main(string[] args)
            {

                Console.WriteLine("What number would you like to perform operations on?");
                int numberChosen = Convert.ToInt32(Console.ReadLine());

            int operationResult = Methods.Operation1(numberChosen);
            Console.WriteLine(operationResult);
            operationResult = Methods.Operation2(numberChosen);
            Console.WriteLine(operationResult);
            operationResult = Methods.Operation3(numberChosen);
            Console.WriteLine(operationResult);
            Console.ReadLine();

        }
        }
}
