

using System.Linq;

namespace CodeWars.MultiplesOf3Or5
{
    public static class Kata
    {
        public static int Solution(int n)
        {
            return Enumerable.Range(0, n).Where(v => v % 3 == 0 || v % 5 == 0).Sum();
        }
    } 
}