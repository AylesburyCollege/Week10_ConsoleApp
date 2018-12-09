using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ConsoleApp.Unit2
{
    /// <summary>
    /// This class adds passengers to a Ferry until the
    /// maximum weight is exceeded.
    /// 
    /// CO452 Unit 2: Task 3.3
    /// 04/12/2018 by Derek Peacock
    /// </summary>
    class T33_Ferry
    {
        public const double MAX_WEIGHT = 2400;

        public static void Load()
        {
            double weight = 0;
            double totalWeight = 0;
            int count = 0;
            decimal moneyTaken = 0;
            bool isFull = false;

            while (!isFull)
            {
                count++;

                weight = UserLib.GetDouble("Enter next passenger weight > ");

                if (totalWeight + weight > MAX_WEIGHT)
                {
                    Console.WriteLine("Max weight exceeded!");
                    Console.WriteLine("Passenger Rejected!");
                    isFull = true;
                    count--;
                }
                else
                {
                    Console.WriteLine("Passenger Accepted!");
                    moneyTaken += 100;
                    totalWeight += weight;
                }
            }

            Console.WriteLine("Total Money = " + moneyTaken.ToString("c"));
            Console.WriteLine("Number of Passenger = " + count);
            Console.WriteLine("Total Weight = " + totalWeight.ToString("####"));
        }
    }
}
