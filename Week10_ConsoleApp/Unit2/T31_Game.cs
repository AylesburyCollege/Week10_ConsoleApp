using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ConsoleApp.Unit2
{
    /// <summary>
    /// This class cost of buyinng 6 weapons
    /// 
    /// CO452 Unit 2: Task 3.1
    /// 04/12/2018 by Derek Peacock
    /// </summary>
    class T31_Game
    {
        public static void BuyWeapons()
        {
            decimal money;
            decimal price;
            int count = 0;
            decimal total = 0;
            decimal moneyLeft = 0;

            UserLib.WriteTitle("Game Store");
            money = UserLib.GetDecimal("Enter the amount of money you have to spend > ");

            for (count = 1; count <= 6; count++)
            {
                price = UserLib.GetDecimal("Enter the price of item " + count + " > ");

                total += price;
                moneyLeft = money - total;
                Console.WriteLine("Money Left = " + moneyLeft.ToString("c"));
            }

            Console.WriteLine();
            Console.WriteLine("You have bought " + count + " weapons");
            Console.WriteLine("Total Cost = " + total.ToString("c"));
            Console.WriteLine("Money Left = " + moneyLeft.ToString("c"));

        }
    }
}
