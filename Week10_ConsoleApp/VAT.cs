using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ConsoleApp
{
    /// <summary>
    /// This class calculates to amount of VAT on
    /// the price of an item
    /// 
    /// CO452 Unit 1: Task 1.2
    /// 02/12/2018 by Derek Peacock
    /// </summary>
    class VAT
    {
        private static string input;
        private static decimal price;
        private static decimal vat;

        public static void Calculate()
        {
            Console.Write("Enter the price of your item > ");
            input = Console.ReadLine();

            price = Convert.ToDecimal(input);
            vat = 17.5m * price / 100;

            Console.WriteLine();
            Console.WriteLine("VAT = " + vat);
        }

    }
}
