using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Grant";
            //Use "\" before a quote inside of a quote to distinguish an escape sequence. \n = newline
            string quote = "The man said, \"Hello!\", Grant. \n Hello on a new line. \n \t Hello on a tab";
            //Use double "\\" to actually put one, it let's it know you actually want a "\"
            //You could also do the "@" sign before the string, that says everything in it has no escapse sequence.
            string fileName = @"C:\Users\Grant";

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("t");

            int length = name.Length;

            name = name.ToUpper();
            name = name.ToLower();

            Console.WriteLine(name);
            Console.ReadLine();

            //When you create a string, you cannot change it.It is allocated to memory.When you change a
            //string, it's not changed, just a new string is created. Using StringBuilder you can create a
            //string object that can expand and collapse, not using more memory than needed.

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Grant");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
