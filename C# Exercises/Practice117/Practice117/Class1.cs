using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice117
{
    class Class1
    {

        public int Division(int newData)
        {
            int quotient = newData / 2;
            return quotient;
        }

        public void Multiply(out int x)
        {
            x = 5 * 100;
        }

        public string Multiply(string name)
        {
            string helloName = "Hi " + name;
            return helloName;
        }

    }

    static class TestClass
    {
        public static void TestMethod()
        {
            Console.WriteLine("Nothing to see here");
        }
    }
}
