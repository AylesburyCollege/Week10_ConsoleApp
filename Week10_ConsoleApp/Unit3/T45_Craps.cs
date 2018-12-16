using System;

namespace Week10_ConsoleApp.Unit3
{
    class T45_Craps
    {
        public static void Play()
        {
            bool won = false;
            bool lost = false;

            int diceNo1;
            int diceNo2;
            int total;

            UserLib.WriteTitle("Craps Game");
            while (!won && !lost)
            {
                diceNo1 = Dice.Throw();
                diceNo2 = Dice.Throw();
                total = diceNo2 + diceNo1;

                Console.WriteLine("Total = " + total);
                Console.ReadKey();

                if((total == 2) || (total == 3) || (total == 12))
                {
                    lost = true;
                    Console.WriteLine("You have lost!!!");
                }
               
            }
        }
    }
}
