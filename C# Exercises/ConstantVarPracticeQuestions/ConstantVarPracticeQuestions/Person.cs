using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVarPracticeQuestions
{
    class Person
    {
            
        public string Name { get; set; }
        public int Amount { get; set; }

        public Person() : this("No Name", 500)
        {
        }

        public Person(string firstNames) : this(firstNames, 500)
        {
        }

        public Person(string firstNames, int money)
        {
            Amount = money;
            Name = firstNames;
        }

    }
}
