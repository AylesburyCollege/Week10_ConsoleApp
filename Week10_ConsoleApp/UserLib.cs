using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ConsoleApp
{
    /// <summary>
    /// This class contains useful methods that can be used 
    /// in a variety of other Console programs
    /// 
    /// Author: Derek Peacock
    /// </summary>
    class UserLib
    {
        public static void  WriteTitle(string title)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Derek's " + title);
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        public static int GetInt(string prompt)
        {
            int mark;
            string input;

            Console.Write(prompt);
            input = Console.ReadLine();
            mark = Convert.ToInt32(input);

            return mark;
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        public static decimal GetDecimal(string prompt)
        {
            decimal amount;
            string input;

            Console.Write(prompt);
            input = Console.ReadLine();
            amount = Convert.ToDecimal(input);

            return amount;
        }
    }
}
