using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPracticeQuestions
{
    class IntegerInput
    {

        public int MathOperation(int input1)
        {
            int operation = input1 * 100;
            return operation;
        }

        public double MathOperation(double input1)
        {
            double operation = input1 + 57.78;
            return operation;
        }

        public int MathOperation(string input1)
        {
            int input2 = Convert.ToInt32(input1);
            int operation = input2 - 33;
            int operation2 = Convert.ToInt32(operation);
            return operation2;
        }
    }
}
