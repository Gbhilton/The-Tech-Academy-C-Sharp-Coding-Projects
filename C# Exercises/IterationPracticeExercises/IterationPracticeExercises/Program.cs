using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main(string[] args)
        {

        ////1.Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that goes through each string in the Array, adding the user’s text to the string.Then create a loop that prints off each string in the Array on a separate line.

        //string[] nameArray = { "My name is ", "Your name is not ", "His name is ", "Her name is " };

        //Console.WriteLine("Input your name:");
        //string input = Console.ReadLine();

        //for (int i = 0; i < nameArray.Length; i++)
        //{
        //    nameArray[i] = nameArray[i] + input;
        //}

        //for (int j = 0; j < nameArray.Length; j++)
        //{
        //    Console.WriteLine(nameArray[j]);
        //}
        //Console.ReadLine();


        ////2.Create an infinite loop.

        //for (int i = 0; i == i; i++)
        //{
        //    Console.WriteLine("This is an infinite loop");
        //}
        //Console.ReadLine();

        ////3.Fix the infinite loop so it will execute.

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("This is not infinite loop");
        //}
        //Console.ReadLine();

        ////4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

        //for (int i = 0; i < 6; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.ReadLine();

        ////5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

        //for (int i = 0; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.ReadLine();

        ////6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.

        //List<string> stringList = new List<string>() { "Mike", "Terry", "Harlen", "Doug", "Dave", "Sarah" };

        //Console.WriteLine("Choose a name to search for in the list:");
        //string input = Console.ReadLine();

        //for (int i = 0; i < stringList.Count; i++)
        //{
        //    if (stringList[i] == input)
        //    {
        //        Console.WriteLine("The matching index value: " + i);
        //    }
        //}
        //Console.ReadLine();

        ////7.Add code to that above loop that tells a user if they put in text that isn’t in the List.

        //List<string> stringList = new List<string>() { "Mike", "Terry", "Harlen", "Doug", "Dave", "Sarah" };

        //Console.WriteLine("Choose a name to search for in the list:");
        //string input = Console.ReadLine();

        //for (int i = 0; i < stringList.Count; i++)
        //{
        //    if (stringList[i] == input)
        //    {
        //        Console.WriteLine("The matching index value: " + i);
        //    }
        //    else
        //    {
        //        Console.WriteLine("The matching index value: Not found");
        //    }
        //}
        //Console.ReadLine();

        ////8.Add code to that above loop that stops it from executing once a match has been found.

        //List<string> stringList = new List<string>() { "Mike", "Terry", "Harlen", "Doug", "Dave", "Sarah" };

        //Console.WriteLine("Choose a name to search for in the list:");
        //string input = Console.ReadLine();

        //for (int i = 0; i < stringList.Count; i++)
        //{
        //    if (stringList[i] != input)
        //    {
        //        Console.WriteLine("The matching index value: Not found");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The matching index value: " + i);
        //        break;
        //    }
        //}
        //Console.ReadLine();

        ////9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.

        //List<string> stringList = new List<string>() { "Mike", "Terry", "Harlen", "Doug", "Dave", "Sarah", "Doug", "Steve", "Steve" };

        //Console.WriteLine("Choose a name to search for in the list:");
        //string input = Console.ReadLine();

        //for (int i = 0; i < stringList.Count; i++)
        //{
        //    if (stringList[i] != input)
        //    {
        //        Console.WriteLine("The matching index value: Not found");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The matching index value: " + stringList.IndexOf(input));
        //        stringList[i] = " ";
        //    }
        //}
        //Console.ReadLine();

        ////10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

        //List<string> stringList = new List<string>() { "Mike", "Terry", "Harlen", "Doug", "Dave", "Sarah", "Doug", "Steve", "Steve" };

        //Console.WriteLine("Choose a name to search for in the list:");
        //string input = Console.ReadLine();

        //for (int i = 0; i < stringList.Count; i++)
        //{
        //    if (stringList[i] != input)
        //    {
        //        Console.WriteLine("The matching index value: The value you entered is not in the list");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The matching index value: " + stringList.IndexOf(input));
        //        stringList[i] = " ";
        //    }
        //}
        //Console.ReadLine();

        ////11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

        //List<string> stringList = new List<string>() { "Mike", "Terry", "Harlen", "Doug", "Dave", "Sarah", "Doug", "Steve", "Steve" };
        //List<string> newStringList = new List<string>();

        //foreach (string name in stringList)
        //{
        //    if (newStringList.Contains(name))
        //    {
        //        Console.WriteLine("Has the name " + name + " appeared already?: Yes" );
        //    }
        //    else
        //    {
        //        Console.WriteLine("Has the name " + name + " appeared already?: No");
        //        newStringList.Add(name);
        //    }
        //}
        //Console.ReadLine();
    }
}

