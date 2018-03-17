using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting
{
    public class Kata
    {
        public static int CountBits(int n)
        {
            // Count the number of bits set to 1 for a given integer

            // my solution.
            int result = 0;
            while (n > 0)
            {
                result += n & 1;
                n >>= 1;
            }
            return result;

            // Cool solutions.
            //return Convert.ToString(n, 2).Count(x => x == 1);
            //return (n == 0) ? 0 : (n & 1) + CountBits(n >> 1);

        }
    }
}
