using System;
using System.Globalization;

namespace oop_assignment_2_2025_73948.Questions
{
    public static class ExamQuestion_4
    {
        public static void Run()
        {
            Console.WriteLine("-- Question 4A Demonstration --");
            int[] ints = { 42, 7, 0, 12345, 123456 };
            foreach (var val in ints)
            {
                Console.WriteLine(val + " -> " + FormatFiveDigits(val));
            }
            Console.WriteLine();
            Console.WriteLine("-- Question 4B Demonstration --");
            decimal[] prices = { 1234.5m, 0m, 9999999.99m };
            foreach (var price in prices)
            {
                Console.WriteLine(price + " -> " + FormatPrice(price));
            }
            Console.WriteLine();
        }

        public static string FormatFiveDigits(int value)
        {
            return value.ToString("D5");
        }

        public static string FormatPrice(decimal price)
        {
            return "€" + price.ToString("N2", CultureInfo.InvariantCulture);
        }
    }
}