using System.Collections;
using System.Linq;

namespace CodeWars.SortTheOdd
{
    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            var oddNumbers = new Stack(array.Where(x => x % 2 != 0).OrderByDescending(x => x).ToArray());
            return array.Select((x) => x % 2 == 0 ? x : (int)oddNumbers.Pop()).ToArray();
        }
    } 
}