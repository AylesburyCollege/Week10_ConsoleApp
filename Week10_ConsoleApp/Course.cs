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
        private static int classMark, isMark, totalMark;
        private static double average;

        public static void CalulateMarks()
        {
            classMark = GetMark("Enter the class mark > ");
            isMark = GetMark("Enter the IS Mark > ");


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
