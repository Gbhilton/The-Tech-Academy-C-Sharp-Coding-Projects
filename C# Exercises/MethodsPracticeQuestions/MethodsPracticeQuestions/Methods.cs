using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPracticeQuestions
{
    class Methods
    {
        //1. Create a class. In that class, create three methods, each of which will take one integer parameter in and 
        //return an integer.The methods should do some math operation on the received parameter.Put this class in a separate.cs file 
        //in the application.

        public static int Operation1(int numberChosen)
        {
            int operationOneResult = numberChosen * 2;
            return operationOneResult;
        }

        public static int Operation2(int numberChosen)
        {
            int operationTwoResult = numberChosen + 5;
            return operationTwoResult;
        }

        public static int Operation3(int numberChosen)
        {
            int operationThreeResult = numberChosen - 100;
            return operationThreeResult;
        }
    }
}
