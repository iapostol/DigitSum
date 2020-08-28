using Xunit;
using static DigitSum.Number;

namespace DigitSum
{
    public class NumberShould
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(9, 9)]
        [InlineData(1, 10)]
        [InlineData(1, 19)]
        [InlineData(6, 456)]
        [InlineData(6, 132189)]
        public void CalculateTheSumOfAllDigits(int expected, int number)
        {
            Assert.Equal(expected, DigitSumOf(number));
        }
    }
}
