using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ConsoleApp
{
    /// <summary>
    /// This class prompts the user to enter their
    /// name and town, and then comments on their entries
    /// 
    /// CO452 Unit 1: Task 1.1
    /// 02/12/2018 by Derek Peacock
    /// </summary>
    class Town
    {
        private static string town;
        
        public static void Check()
        {
            Console.Clear();

            Console.WriteLine("Task 1: Hello There!");
            Console.Write("Enter the town you live in >");

            town = Console.ReadLine();
            Console.WriteLine(town + " is a nice town!");
        }
    }
}
