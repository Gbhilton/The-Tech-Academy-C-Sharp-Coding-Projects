using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInputOutputPracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            //string text1 = "Here is some text";
            //The "@" symbol makes the program read it literally, so there is no need to add another "\" .
            //File.WriteAllText(@"C:\Users\usagxh19\Desktop\Information\Homework\The Tech Academy\C# Projects\FileInputOutputPracticeQuestions\FileInputOutputPracticeQuestions\log.txt", text1);
            //File.WriteAllText("C:\\Users\\usagxh19\\Desktop\\Information\\Homework\\The Tech Academy\\C# Projects\\FileInputOutputPracticeQuestions\\FileInputOutputPracticeQuestions\\log.txt", text1);


            //Reading text from a file.
            //string text2 = File.ReadAllText(@"C:\Users\usagxh19\Desktop\Information\Homework\The Tech Academy\C# Projects\FileInputOutputPracticeQuestions\FileInputOutputPracticeQuestions\log.txt");


            //Appending text in a file. This is helpful when creating a log.
            //string card = "Here is some more text";
            //using (StreamWriter file = new StreamWriter(@"C:\Users\usagxh19\Desktop\Information\Homework\The Tech Academy\C# Projects\FileInputOutputPracticeQuestions\FileInputOutputPracticeQuestions\log.txt", true))
            //{
            //    file.WriteLine(card);
            //}

            //1.Ask a user for a number.

            Console.WriteLine("Please enter a number:");
            string numberEntered = Console.ReadLine();

            //2.Log that number to a text file.

            File.WriteAllText(@"C:\Users\usagxh19\Desktop\Information\Homework\The Tech Academy\C# Projects\FileInputOutputPracticeQuestions\FileInputOutputPracticeQuestions\log.txt", numberEntered);

            //3.Print the text file back to the user.

            string numberReadBack = File.ReadAllText(@"C:\Users\usagxh19\Desktop\Information\Homework\The Tech Academy\C# Projects\FileInputOutputPracticeQuestions\FileInputOutputPracticeQuestions\log.txt");
            Console.WriteLine(numberReadBack);
            Console.ReadLine();

        }
    }
}
