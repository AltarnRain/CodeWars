using System;
using System.Linq;

namespace CodeWars.Playingonachessboard
{
    public class Suite2
    {
        public static string game(long n)
        {
            if (n == 0)
            {
                return "[0]";
            }

            var n2 = n * n;

            if (n2 % 2 == 0)
            {
                return $"[{n2 / 2}]"; ;
            }
            else
            {
                return $"[{n2}, 2]"; ;
            }
        }
    }
}
