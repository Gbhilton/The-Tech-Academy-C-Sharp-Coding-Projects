using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPracticeQuestions
{
    public class InvalidNumberExceptions : Exception
    {
        public InvalidNumberExceptions()
            : base() { }
        public InvalidNumberExceptions(string message)
            : base(message) { }
    }
}
