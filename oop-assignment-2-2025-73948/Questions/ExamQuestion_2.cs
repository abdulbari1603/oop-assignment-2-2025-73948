using System;

namespace oop_assignment_2_2025_73948.Questions
{
    public static class ExamQuestion_2
    {
        public static void Run()
        {
            Console.WriteLine("-- Question 2A Demonstration --");
            Console.WriteLine("Divide(10, 2) = " + Divide(10, 2));
            Console.WriteLine("Divide(10, 0) = " + Divide(10, 0));
            Console.WriteLine();
            Console.WriteLine("-- Question 2B Demonstration --");
            Console.WriteLine("ParseNumber(\"123\") = " + ParseNumber("123"));
            Console.WriteLine("ParseNumber(\"abc\") = " + ParseNumber("abc"));
            Console.WriteLine();
            Console.WriteLine("-- Question 2C Demonstration --");
            Console.WriteLine("RegisterUser(25) = " + RegisterUser(25));
            Console.WriteLine("RegisterUser(15) = " + RegisterUser(15));
            Console.WriteLine();
        }

        public static string Divide(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                return result.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Cannot divide by 0";
            }
        }

        public static string ParseNumber(string input)
        {
            try
            {
                int value = int.Parse(input);
                return value.ToString();
            }
            catch (Exception)
            {
                return "Invalid number entered.";
            }
        }

        public static string RegisterUser(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return "Registration successful.";
            }
            catch (ArgumentOutOfRangeException)
            {
                return "User must be at least 18 to register.";
            }
        }
    }
}