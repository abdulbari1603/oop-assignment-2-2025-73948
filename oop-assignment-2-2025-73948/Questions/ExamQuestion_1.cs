using System;
using System.Text.RegularExpressions;

namespace oop_assignment_2_2025_73948.Questions
{
    public static class ExamQuestion_1
    {
        public static void Run()
        {
            Console.WriteLine("-- Question 1A Demonstration --");
            string[] sampleNumbers = { "0831234567", "0859876543", "0891122334", "0812345678" };
            foreach (var number in sampleNumbers)
            {
                string status = IsValidIrishMobileNumber(number) ? "valid" : "invalid";
                Console.WriteLine(number + ": " + status);
            }
            Console.WriteLine();
            Console.WriteLine("-- Question 1B Demonstration --");
            string[] levels = { "Bronze", "Silver", "Gold", "Platinum", "Diamond", "Boss", "Master", "Unknown" };
            foreach (var level in levels)
            {
                int discount = GetDiscountPercentage(level);
                Console.WriteLine(level + ": " + discount + "% discount");
            }
            Console.WriteLine();
        }

        public static bool IsValidIrishMobileNumber(string? number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }
            Regex regex = new(@"^(083|085|089)\d{7}$");
            return regex.IsMatch(number);
        }

        public static int GetDiscountPercentage(string? level)
        {
            if (string.IsNullOrEmpty(level)) return 0;
            return level.ToLowerInvariant() switch
            {
                "bronze" => 1,
                "silver" => 5,
                "gold" => 10,
                "platinum" => 15,
                "diamond" => 20,
                "boss" => 25,
                "master" => 30,
                _ => 0
            };
        }
    }
}
