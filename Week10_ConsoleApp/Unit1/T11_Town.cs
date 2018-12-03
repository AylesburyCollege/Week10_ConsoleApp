﻿using System;

namespace Week10_ConsoleApp
{
    /// <summary>
    /// This class prompts the user to enter their
    /// name and town, and then comments on their entries
    /// 
    /// CO452 Unit 1: Task 1.1
    /// 02/12/2018 by Derek Peacock
    /// </summary>
    class T11_Town
    {
        private static string town;
        
        public static void Check()
        {
            Console.Clear();

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Derek's Town Checker     ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("Task 1: Hello There!");
            Console.Write("Enter the town you live in >");

            town = Console.ReadLine();
            Console.WriteLine(town + " is a nice town!");
        }
    }
}
