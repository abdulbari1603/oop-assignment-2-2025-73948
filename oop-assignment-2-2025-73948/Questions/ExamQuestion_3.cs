using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_assignment_2_2025_73948.Questions
{
    public static class ExamQuestion_3
    {
        public static void Run()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int> { 4, 3, 5 }),
                ("Keyboard", new List<int> { 5, 5, 5, 4 }),
                ("Mouse", new List<int> { 3, 3, 4 })
            };
            var result = EvaluateProducts(products);
            Console.WriteLine("-- Question 3 Demonstration --");
            foreach (var summary in result.Summaries)
            {
                Console.WriteLine(summary);
            }
            Console.WriteLine(result.TopProductMessage);
            Console.WriteLine();
        }

        public static (List<string> Summaries, string TopProductMessage) EvaluateProducts(List<(string Name, List<int> Ratings)> products)
        {
            if (products == null) throw new ArgumentNullException(nameof(products));
            var summaries = new List<string>();
            string? topProductName = null;
            double topAverage = double.MinValue;
            foreach (var item in products)
            {
                string name = item.Name;
                List<int> ratings = item.Ratings;
                if (ratings == null || ratings.Count == 0)
                {
                    summaries.Add(name + ": No ratings available");
                    continue;
                }
                double average = ratings.Average();
                double rounded = Math.Round(average, 1);
                summaries.Add(name + ": Average Rating = " + rounded.ToString("0.0"));
                if (average > topAverage)
                {
                    topAverage = average;
                    topProductName = name;
                }
            }
            string topMessage;
            if (topProductName == null)
            {
                topMessage = "No ratings available to determine top product";
            }
            else
            {
                double roundedTop = Math.Round(topAverage, 1);
                topMessage = "The top-rated product is " + topProductName + " with an average rating of " + roundedTop.ToString("0.0");
            }
            return (summaries, topMessage);
        }
    }
}