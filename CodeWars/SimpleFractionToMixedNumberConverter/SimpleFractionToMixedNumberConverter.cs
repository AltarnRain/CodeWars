using System;
using System.Linq;

namespace CodeWars.SimpleFractionToMixedNumberConverter
{
    public class Kata
    {

        //public static string MixedFraction(string s)
        //{
        //    long num = Convert.ToInt64(s.Split('/')[0]);
        //    long den = Convert.ToInt64(s.Split('/')[1]);

        //    if (den < 0)
        //    { num *= -1; den *= -1; }

        //    if (den == 0)
        //        throw new DivideByZeroException();

        //    Func<long, long, long> gcd = null;
        //    gcd = (a, b) => b == 0 ? a : gcd(b, a % b);

        //    if (num % den != 0)
        //        return string.Format("{0} {1}/{2}", num / den == 0 ? string.Empty : (num / den).ToString(),
        //                                                  num / den == 0 ? (num % den) / Math.Abs(gcd.Invoke(num, den)) : Math.Abs((num % den) / gcd.Invoke(num, den)),
        //                                                  num / den == 0 ? den / Math.Abs(gcd.Invoke(num, den)) : Math.Abs(den / gcd.Invoke(num, den))).Trim();
        //    else
        //        return (num / den).ToString();
        //}

        public static string MixedFraction(string s)
        {
            var numbers = s.Split('/').Select(int.Parse).Select(n => Math.Abs(n)).ToArray();
            if (numbers[1] == 0)
            {
                throw new DivideByZeroException();
            }

            if (numbers[0] == 0)
            {
                return "0";
            }

            var isNegative = s.Count(i => i == '-') % 2 != 0;
            var fractionString = string.Empty;

            var whole = numbers[0] / numbers[1];
            if (numbers[0] % numbers[1] > 0)
            {
                var remain = (double)Decimal.Divide(numbers[0], numbers[1]) - whole;
                fractionString = RealToFraction(remain, 0.00000000000001);
            }

            var returnValue = string.Empty;
            if (whole == 0)
            {
                returnValue = fractionString;
            }
            else
            {
                returnValue = fractionString == string.Empty ? whole.ToString() : whole.ToString() + " " + fractionString;
            }

            if (isNegative) returnValue = "-" + returnValue;
            return returnValue;
        }

        public static string RealToFraction(double value, double accuracy)
        {
            var n = (int)Math.Floor(value);
            value -= n;

            var lower_n = 0;
            var lower_d = 1;

            var upper_n = 1;
            var upper_d = 1;

            while (true)
            {
                int middle_n = lower_n + upper_n;
                int middle_d = lower_d + upper_d;

                if (middle_d * (value + accuracy) < middle_n)
                {
                    upper_n = middle_n;
                    upper_d = middle_d;
                }
                else if (middle_n < (value - accuracy) * middle_d)
                {
                    lower_n = middle_n;
                    lower_d = middle_d;
                }
                else
                {
                    return $"{(n * middle_d + middle_n)}/{middle_d}";
                }
            }
        }
    }
}
