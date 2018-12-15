using System;

namespace Week10_ConsoleApp.Unit3
{
    class T41_Meals
    {
        double dayCost, weekCost; // define all class variables (attributes)
        double foodCost, drinkCost;
        int daysPerWeek; // number of days attending college

        public void InputData() // method to input data from keyboard
        {
            string input; // local input variable

            Console.Write("Enter the price of a meal: £");
            input = Console.ReadLine();
            foodCost = Convert.ToDouble(input);

            Console.Write("Enter the price of a drink: £");
            input = Console.ReadLine();
            drinkCost = Convert.ToDouble(input);

            Console.Write("Enter the number of days per week at college: ");
            input = Console.ReadLine();
            daysPerWeek = Convert.ToInt32(input);
        }

        public void CalculateTotalCosts()
        {
            dayCost = foodCost + (3 * drinkCost);
            weekCost = dayCost * daysPerWeek;
        }

        public void OutputCosts()
        {
            Console.WriteLine("\nYour Final Costing Results");
            Console.WriteLine("==========================");
            Console.WriteLine("Total cost for one day = £" + dayCost.ToString("0.00"));
            Console.WriteLine("Total cost for one week = £" + weekCost.ToString("0.00"));
        }
    }
}
