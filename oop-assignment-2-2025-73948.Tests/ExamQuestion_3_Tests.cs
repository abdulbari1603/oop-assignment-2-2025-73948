using System.Collections.Generic;
using oop_assignment_2_2025_73948.Questions;
using Xunit;

namespace oop_assignment_2_2025_73948.Tests
{
    public class ExamQuestion_3_Tests
    {
        [Fact]
        public void EvaluateProducts_ReturnsCorrectSummariesAndTopProduct_ForSampleData()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int> { 4, 3, 5 }),
                ("Keyboard", new List<int> { 5, 5, 5, 4 }),
                ("Mouse", new List<int> { 3, 3, 4 })
            };
            var result = ExamQuestion_3.EvaluateProducts(products);
            Assert.Contains("Laptop: Average Rating = 4.2", result.Summaries);
            Assert.Contains("Headphones: Average Rating = 4.0", result.Summaries);
            Assert.Contains("Keyboard: Average Rating = 4.8", result.Summaries);
            Assert.Contains("Mouse: Average Rating = 3.3", result.Summaries);
            Assert.Equal(4, result.Summaries.Count);
            Assert.Equal("The top-rated product is Keyboard with an average rating of 4.8", result.TopProductMessage);
        }

        [Fact]
        public void EvaluateProducts_HandlesEmptyRatingLists()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Book", new List<int>()),
                ("Pen", new List<int> { 4, 5 })
            };
            var result = ExamQuestion_3.EvaluateProducts(products);
            Assert.Contains("Book: No ratings available", result.Summaries);
            Assert.Contains("Pen: Average Rating = 4.5", result.Summaries);
            Assert.Equal("The top-rated product is Pen with an average rating of 4.5", result.TopProductMessage);
        }
    }
}