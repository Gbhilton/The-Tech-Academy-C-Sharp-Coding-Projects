using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main(string[] args)
        {

        ////1.Create a list of integers. Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

        //List<int> integerList = new List<int>() { 45, 23, 56, 68, 11, 99 };

        //Console.WriteLine("Pick a number to divide each number in the list by.");
        //int numberOne = Convert.ToInt32(Console.ReadLine());

        //foreach (int number in integerList)
        //{
        //    int quotent = number / numberOne;
        //    Console.WriteLine(number + " divided by " + numberOne + " equals " + quotent);
        //}

        //Console.ReadLine();


        //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.

        //Successfully ran. Entered the number 5

        //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.

        //System.DivideByZeroException: 'Attempted to divide by zero.'. This error was returned.

        //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.

        //System.FormatException: 'Input string was not in a correct format.'. This is the error that was returned.

        ////5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program display a message to the display to let 
        ////you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.
        ////Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

        //try
        //{
        //    List<int> integerList = new List<int>() { 45, 23, 56, 68, 11, 99 };

        //    Console.WriteLine("Pick a number to divide each number in the list by.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());

        //    foreach (int number in integerList)
        //    {
        //        int quotent = number / numberOne;
        //        Console.WriteLine(number + " divided by " + numberOne + " equals " + quotent);
        //    }

        //    Console.ReadLine();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Please type a whole number");
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please don't divide by zero");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("The program has emerged from the try/catch block and has executed");
        //    Console.ReadLine();
        //}

    }
}
