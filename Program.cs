using System;

namespace Operator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double mealCost;
            int tipPercent;
            int taxPercent;
            double totalCost;

            mealCost = Convert.ToDouble(Console.ReadLine());
            tipPercent = Convert.ToInt32(Console.ReadLine());
            taxPercent = Convert.ToInt32(Console.ReadLine());

            var tip = mealCost * tipPercent / 100;
            var tax = mealCost * taxPercent / 100;
            totalCost = mealCost + tip + tax;
            //var round = Math.Round(totalCost);


            Console.WriteLine("The total meal cost is " + Math.Round(totalCost) + " dollars.");
            Console.ReadKey();
        }
    }
}