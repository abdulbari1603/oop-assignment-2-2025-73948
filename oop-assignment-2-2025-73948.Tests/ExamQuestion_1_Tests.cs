using oop_assignment_2_2025_73948.Questions;
using Xunit;

namespace oop_assignment_2_2025_73948.Tests
{
    public class ExamQuestion_1_Tests
    {
        [Theory]
        [InlineData("0831234567", true)]
        [InlineData("0899988776", true)]
        [InlineData("0812345678", false)]
        [InlineData("083 1234567", false)]
        [InlineData("08312345678", false)]
        [InlineData("0859876543", true)]
        [InlineData("0891122334", true)]
        public void IsValidIrishMobileNumber_ReturnsExpected(string number, bool expected)
        {
            bool actual = ExamQuestion_1.IsValidIrishMobileNumber(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Bronze", 1)]
        [InlineData("Silver", 5)]
        [InlineData("Gold", 10)]
        [InlineData("Platinum", 15)]
        [InlineData("Diamond", 20)]
        [InlineData("Boss", 25)]
        [InlineData("Master", 30)]
        [InlineData("Unknown", 0)]
        [InlineData("", 0)]
        [InlineData(null, 0)]
        public void GetDiscountPercentage_ReturnsCorrect(string? level, int expected)
        {
            int actual = ExamQuestion_1.GetDiscountPercentage(level);
            Assert.Equal(expected, actual);
        }
    }
}