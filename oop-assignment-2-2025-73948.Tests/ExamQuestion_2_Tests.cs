using oop_assignment_2_2025_73948.Questions;
using Xunit;

namespace oop_assignment_2_2025_73948.Tests
{
    public class ExamQuestion_2_Tests
    {
        [Theory]
        [InlineData(10, 2, "5")]
        [InlineData(-10, 2, "-5")]
        [InlineData(0, 5, "0")]
        public void Divide_ReturnsQuotient_WhenDivisorNonZero(int numerator, int denominator, string expected)
        {
            string actual = ExamQuestion_2.Divide(numerator, denominator);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_ReturnsErrorMessage_WhenDivisorIsZero()
        {
            string result = ExamQuestion_2.Divide(10, 0);
            Assert.Equal("Cannot divide by 0", result);
        }

        [Theory]
        [InlineData("123", "123")]
        [InlineData("0", "0")]
        [InlineData("-42", "-42")]
        public void ParseNumber_ReturnsParsedString_ForValidIntegers(string input, string expected)
        {
            string actual = ExamQuestion_2.ParseNumber(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abc")]
        [InlineData("")]
        [InlineData("12.3")]
        public void ParseNumber_ReturnsErrorMessage_ForInvalidInput(string input)
        {
            string actual = ExamQuestion_2.ParseNumber(input);
            Assert.Equal("Invalid number entered.", actual);
        }

        [Theory]
        [InlineData(18, "Registration successful.")]
        [InlineData(25, "Registration successful.")]
        public void RegisterUser_ReturnsSuccess_ForAdultAge(int age, string expected)
        {
            string actual = ExamQuestion_2.RegisterUser(age);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(17)]
        [InlineData(0)]
        [InlineData(-5)]
        public void RegisterUser_ReturnsError_ForUnderage(int age)
        {
            string actual = ExamQuestion_2.RegisterUser(age);
            Assert.Equal("User must be at least 18 to register.", actual);
        }
    }
}
