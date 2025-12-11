using oop_assignment_2_2025_73948.Questions;
using Xunit;

namespace oop_assignment_2_2025_73948.Tests
{
    public class ExamQuestion_4_Tests
    {
        [Theory]
        [InlineData(42, "00042")]
        [InlineData(7, "00007")]
        [InlineData(0, "00000")]
        [InlineData(12345, "12345")]
        [InlineData(123456, "123456")]
        public void FormatFiveDigits_ReturnsStringWithLeadingZeros(int input, string expected)
        {
            string actual = ExamQuestion_4.FormatFiveDigits(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1234.5, "€1,234.50")]
        [InlineData(0.0, "€0.00")]
        [InlineData(9999999.99, "€9,999,999.99")]
        [InlineData(12.3456, "€12.35")]
        public void FormatPrice_ReturnsFormattedString(double input, string expected)
        {
            decimal price = (decimal)input;
            string actual = ExamQuestion_4.FormatPrice(price);
            Assert.Equal(expected, actual);
        }
    }
}
