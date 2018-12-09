using System;

namespace Week10_ConsoleApp.Unit2
{
    /// <summary>
    /// This class checks pressures to see if they are safe
    /// 
    /// CO452 Unit 2: Task 3.4
    /// 04/12/2018 by Derek Peacock
    /// </summary>
    class T34_Pressure
    {
        public const int LOW_PRESSURE = 10;
        public const int HIGH_PRESSURE = 100;
        public const int DANGEROUS_PRESSURE = 125;

        public static void Check()
        {
            bool isSafe = true;
            int pressure;

            UserLib.WriteTitle("Pressure Check");

            while(isSafe)
            {
                pressure = UserLib.GetInt("Enter Pressure > ");

                if (pressure < LOW_PRESSURE)
                {
                    Console.WriteLine("Pressure is too low!");
                }
                else if ((pressure >= LOW_PRESSURE) && (pressure <= HIGH_PRESSURE))
                {
                    Console.WriteLine("Pressure is Normal!");
                }
                else if ((pressure > HIGH_PRESSURE) && (pressure < DANGEROUS_PRESSURE))
                {
                    Console.WriteLine("Pressure is too high!");
                }
                else if (pressure >= DANGEROUS_PRESSURE)
                {
                    Console.WriteLine("Pressure is DANGEROUS!");
                    isSafe = false;
                }
            }

            Console.WriteLine("Shut Down!!!");
        }
    }
}
