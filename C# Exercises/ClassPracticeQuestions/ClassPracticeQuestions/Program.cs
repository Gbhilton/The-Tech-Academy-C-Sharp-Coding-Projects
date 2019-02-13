using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Create a class. In that class, create a void method that takes two integers as parameters.Have the method do a 
            //math operation on the first integer and display the second integer to the screen.

            //Done. The class is called "TwoIntegerClass" with the method "DoubleIntInput".

            //2. In the Main() method of the console app, instantiate the class.

            TwoIntegerClass inputvalues = new TwoIntegerClass();

            //3. Call the method in the class, passing in two numbers.

            inputvalues.DoubleIntInput(25, 55);

            //4. Call the method in the class, specifying the parameters by name.

            inputvalues.DoubleIntInput(input1: 25, input2:  55);

        }
    }
}
