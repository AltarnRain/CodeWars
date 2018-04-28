using System.Collections.Generic;
using System.Linq;

namespace CodeWars.CountCharactersInString
{
    public class Kata
    {
        public static Dictionary<char, int> Count(string str)
        {
            return str.Distinct().ToDictionary(p => p, p => str.Count(s => s == p));
        }
    }
}
