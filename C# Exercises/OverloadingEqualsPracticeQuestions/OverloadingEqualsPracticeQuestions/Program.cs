using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingEqualsPracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee();
            employee1.Id = 44;
            employee1.Name = "Grant";
            Employee employee2 = new Employee();
            employee2.Id = 33;
            employee2.Name = "Brad";

            bool employeeCheck = employee1 == employee2;
            Console.WriteLine(employeeCheck);
            Console.ReadLine();

        }
    }
}
