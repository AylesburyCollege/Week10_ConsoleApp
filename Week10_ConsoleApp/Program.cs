using System;
using Week10_ConsoleApp.Unit3;
using Week10_ConsoleApp.Unit2;

namespace Week10_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RunUnit1();
            //RunUnit2();

            RunMeals();

            Console.ReadKey();
        }

        private static void RunUnit2()
        {
            T31_Game.BuyWeapons();
            T32_Display.ShowName();
            T33_Ferry.Load();
            T34_Pressure.Check();
        }

        private static void RunUnit1()
        {
            T11_Town.Check();
            T12_VAT.Calculate();
            T13_Course.CalulateMarks();
            T14_Salary.Calculate();
            T15_Concert.BuyTickets();
        }

        /// <summary>
        /// Use the Meals class to calculate the total cost of
        /// meals and drinks for a week at College
        /// </summary>
        private static void RunMeals()
        {
            T41_Meals myMeals = new T41_Meals(); 

            myMeals.InputData();  
            myMeals.CalculateTotalCosts(); 
            myMeals.OutputCosts(); 
        }
    }
}
