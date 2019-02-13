using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingEqualsPracticeQuestions
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static Boolean operator== (Employee employee1, Employee employee2)
        {
            bool factCheck = employee1.Id == employee2.Id;
            return factCheck;
        }

        public static Boolean operator!= (Employee employee1, Employee employee2)
        {
            bool factCheck = employee1.Id == employee2.Id;
            return factCheck;
        }
    }
}