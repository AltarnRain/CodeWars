using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.SquareIntoSquares
{
    public class Decompose
    {

        public string decompose(long n)
        {
            var square = Math.Pow(n, 2);
            var start = n - 1;
            var numbers = new List<List<long>>
            {
                new List<long>()
            };

            bool improve = true;
            while (improve)
            {
                while (square != 0 && start != 0)
                {
                    if (square - Math.Pow(start, 2) >= 0)
                    {
                        numbers.Last().Add(start);
                        square -= Math.Pow(start, 2);
                    }

                    start--;
                }
            }

            numbers.Sort();

            return string.Join(" ", numbers);
        }
    }
}
