using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesPracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Make the Employee class take a generic type parameter.

            //Completed. Added <T> after the "Employee" class name.

            //2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

            //Added this line to the Employee class. "public List<T> things { get; set; }"

            //3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.

            Employee<string> newEmpString = new Employee<string>();
            newEmpString.things = new List<string>() { "car", "house", "dog", "lasso" };

            //4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.

            Employee<int> newEmpInt = new Employee<int>();
            newEmpInt.things = new List<int>() { 44, 22, 33, 11 };

            //5. Create a loop that prints all of the Things to the Console.

        void Listthings()
        {
            foreach (string thing in newEmpString.things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in newEmpInt.things)
            {
                    Console.WriteLine(thing);
            }
        }

            Listthings();
            Console.ReadLine();

        }
    }
}
