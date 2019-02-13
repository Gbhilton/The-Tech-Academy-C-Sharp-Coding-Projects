using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        //1.Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

        string[] stringArray = new string[] { "Grant", "Cat", "Gerardo", "Vincent", "Tanner" };

        Console.WriteLine("Select a index number of this string array (0-4):");
        int arrayIndexString = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringArray[arrayIndexString]);
        Console.ReadLine();

        //2.Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

        int[] intArray = new int[] { 4, 69, 234, 3457, 32499 };

        Console.WriteLine("Select a index number of this integer array (0-4):");
        int arrayIndexInt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(intArray[arrayIndexInt]);
        Console.ReadLine();

        //3.Add in a message that displays when the user selects an index that doesn’t exist.

        int[] intArray = new int[] { 4, 69, 234, 3457, 32499 };

        Console.WriteLine("Select a index number of this integer array (0-4):");
        int arrayIndexInt = Convert.ToInt32(Console.ReadLine());

        if (arrayIndexInt >= 0 && arrayIndexInt < 5)
        {
            Console.WriteLine(intArray[arrayIndexInt]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Error: This index in the Array does not exist, try again.");
            Console.ReadLine();
        }


        //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

        List<string> stringList = new List<string>();
        stringList.Add("Grant");
        stringList.Add("Hi");
        stringList.Add("The");
        stringList.Add("Tech");
        stringList.Add("Academy");
        stringList.Add("Chat");

        Console.WriteLine("Select a index number of this string array (0-5):");
        int listIndexString = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(stringList[listIndexString]);
        Console.ReadLine();

    }
}
