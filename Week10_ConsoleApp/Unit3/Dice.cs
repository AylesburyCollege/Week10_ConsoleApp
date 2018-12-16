using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ConsoleApp.Unit3
{
    public class Dice
    {
        private static Random rand = new Random();

        /// <summary>
        /// pick a number from 1 to 6 and return this single number
        /// </summary>
        public static int Throw()
        {
            return rand.Next(6) + 1;  
        }

        /// <summary>
        /// Throw the dice many times and display the distribution
        /// of numbers
        /// </summary>
        public static void Throw(int manyTimes)
        {
            int [] numbers = new int[6];
            int diceNo;

            for(int throwNo = 1; throwNo <= manyTimes; throwNo++)
            {
                diceNo = Throw();
                numbers[diceNo - 1]++;
            }

            for(diceNo = 1; diceNo <= 6; diceNo++)
            {
                Console.WriteLine(diceNo + " occurs " + numbers[diceNo - 1] + " times");
            }
        }

    }
}
