using System;
using System.Linq;

namespace CodeWars.PlayingWithDigits
{
    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            var sumOfPowers = n.ToString().Select(s => int.Parse(s.ToString())).Select((d, i) => Math.Pow(d, p + i)).Sum();
            return sumOfPowers % n == 0 ? (long)sumOfPowers / n : - 1;
        }
    }
}
