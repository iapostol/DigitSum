using System;
using System.Linq;

namespace DigitSum
{
    public static class Number
    {
        public static long DigitSumOf(long number)
        {
            if (number <= 9)
                return number;

            var total = DigitsOf(number).Sum();

            if (total > 9)
                return DigitSumOf(total);

            return total;
        }

        private static int[] DigitsOf(long number)
        {
            return number.ToString().Select(ch => ch - '0').ToArray();
        }
    }
}