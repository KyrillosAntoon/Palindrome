// Kyrillos "Chris" Antoon
// Palindrome project from C# 2561
// 10/04/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Project
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = null;                                            // String variable for holding the user input
            do
            {
                Console.WriteLine("Enter any word/number(-1 to quit): ");   // Ask user to enter input

                input = Console.ReadLine();                                 // Take in input
                 
                if(input != "-1")
                { 
                Console.WriteLine(palindrome(input) ?                       // Print Palindrome if it is a palindrome, else, print it is not.
                    "It is a palindrome." 
                    : "It is NOT a palindrome");
                }
            } while(input != "-1");                                         // Repeat until user quits



            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }
        /// <summary>
        /// Palindrome algorithm, works for any combination of characters for any size.
        static bool palindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[0 + i] != input[(input.Length - 1) - i])          // Check if characters at opposite sides of the string are equal until you reach the middle letter
                {
                    return false;
                }
            }

            return true;
        }
    }
}
