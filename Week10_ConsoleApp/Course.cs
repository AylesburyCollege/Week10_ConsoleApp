using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ConsoleApp
{
    /// <summary>
    /// This class calculates the average and final
    /// mark for the course
    /// 
    /// CO452 Unit 1: Task 1.2
    /// 02/12/2018 by Derek Peacock
    /// </summary>
    class Course
    {
        private static int classMark, isMark, total;
        private static double average;

        public static void CalulateMarks()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Derek's Marks Calculator ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            classMark = GetMark("Enter the class mark > ");
            isMark = GetMark("Enter the IS Mark > ");

            total = classMark + isMark;
            average = total / 2;

            Console.WriteLine("\nThe total of " + classMark + " and " + isMark + " is " + total);
            Console.WriteLine("and the average mark is " + average);
            Console.WriteLine(); 
        }

        private static int GetMark(string prompt)
        {
            int mark;
            string input;

            Console.Write(prompt);
            input = Console.ReadLine();
            mark = Convert.ToInt32(input);

            return mark;
        }
    }
}
