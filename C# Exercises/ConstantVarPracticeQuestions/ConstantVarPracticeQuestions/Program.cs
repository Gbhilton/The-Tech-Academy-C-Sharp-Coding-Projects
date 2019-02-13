using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVarPracticeQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.Create a const variable

            const string firstName = "Grant";

            //2.Create a variable using the keyword "var".

            var lastName = "Hilton";

            //3.Chain two constructors together.

            Person newPerson = new Person();
            Console.WriteLine(newPerson.Name);
            Console.ReadLine();

        }
    }
}
