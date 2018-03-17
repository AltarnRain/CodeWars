using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.DeleteNth
{
    public class Kata
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            //var returnValue = new List<int>();
            //arr.ToList().ForEach(a => { if (returnValue.Count(n => n == a) < x) returnValue.Add(a); });
            //return returnValue.ToArray();

            return arr.Where((t, i) => arr.Take(i + 1).Count(s => s == t) <= x).ToArray();
        }
    }
}