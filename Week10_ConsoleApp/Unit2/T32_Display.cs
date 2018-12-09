using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Week10_ConsoleApp.Unit2
{
    /// <summary>
    /// This class displays a name many times
    /// 
    /// CO452 Unit 2: Task 3.2
    /// 04/12/2018 by Derek Peacock
    /// </summary>
    class T32_Display
    {
        public static void ShowName()
        {
            int x = 2, y = 10;
            ConsoleColor colour;
            String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));

            string name;
            int count = 0;

            name = "Derek";

            while (count < 10)
            {
                count++;
                y = y + 1;

                UserLib.WriteTitle("Show Name");

                Console.SetCursorPosition(x, y);
                Console.Write(name);
                Thread.Sleep(500);

                Console.Clear();
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorNames[count]);
            }
        }
    }
}
