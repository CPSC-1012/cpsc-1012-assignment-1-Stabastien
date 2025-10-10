// Class: CPSC 1012
// Instructor: Abhilash Hareendranathan
// Author: Villa-E Khan
// Date: October 9th, 2025
// Description: 

using System;

namespace CPSC1012_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter initial number of dragons: ");
            double initialDragons = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter daily growth rate percentage: ");
            double growthRatePercent = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of weeks: ");
            int weeks = Convert.ToInt32(Console.ReadLine());

            double growthRate = growthRatePercent / 100;
            int days = weeks * 7;

            double finalDragons = initialDragons * Math.Pow(1 + growthRate, days);

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"After {weeks} week(s), the hatchery will have approximately {Math.Round(finalDragons, 0)} dragons.");
        }
    }
}
