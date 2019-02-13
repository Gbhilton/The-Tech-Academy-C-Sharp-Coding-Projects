using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, as well as an Id.At least two employees should have the first name "Joe".

            //List<Employees> allEmployees = new List<Employees>();
            //allEmployees.Add(new Employees() { FirstName = "Grant", LastName = "Hilton", Id = 1 });
            //allEmployees.Add(new Employees() { FirstName = "Joe", LastName = "Mason", Id = 2 });
            //allEmployees.Add(new Employees() { FirstName = "Joe", LastName = "Nickels", Id = 3 });
            //allEmployees.Add(new Employees() { FirstName = "Mike", LastName = "Guima", Id = 4 });
            //allEmployees.Add(new Employees() { FirstName = "Dave", LastName = "Carman", Id = 5 });
            //allEmployees.Add(new Employees() { FirstName = "Drew", LastName = "Wheat", Id = 6 });
            //allEmployees.Add(new Employees() { FirstName = "Andy", LastName = "Town", Id = 7 });
            //allEmployees.Add(new Employees() { FirstName = "Jim", LastName = "Bill", Id = 8 });
            //allEmployees.Add(new Employees() { FirstName = "Joe", LastName = "Johnson", Id = 9 });
            //allEmployees.Add(new Employees() { FirstName = "Jason", LastName = "Williams", Id = 10 });


            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".

            //List<Employees> joeList = new List<Employees>();
            //foreach (Employees employee in allEmployees)
            //{
            //    if(employee.FirstName == "Joe")
            //    {
            //       joeList.Add(employee);
            //       Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //    }
            //}

            //Console.ReadLine();

            //3.Do the same thing again, but this time with a lambda expression.

            //List<Employees> joeList2 = allEmployees.Where(x => x.FirstName == "Joe").ToList();
            //joeList2.ForEach(item => Console.WriteLine(item.FirstName + " " + item.LastName));
            //Console.ReadLine();

            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.

            //List<Employees> idList = allEmployees.Where(x => x.Id > 5).ToList();

            //foreach (Employees id in idList)
            //{
            //    Console.WriteLine(id.FirstName + " " + id.LastName + " " + id.Id);
            //}
            //Console.ReadLine();

        }
    }
}
