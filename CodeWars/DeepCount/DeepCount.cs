using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.DeepCount
{
    public class Kata
    {
        public static int DeepCount(object a)
        {
            var count = 0;
            foreach (var o in (a as object[]))
            {
                if (o is object[])
                {
                    count++;
                    count += DeepCount(o);
                }
                else
                {
                    count++;
                }
            }

            return count;
        }
    }
}
