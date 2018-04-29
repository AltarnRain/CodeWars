using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.MexicanWave
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            return Enumerable.Repeat(str, str.Length)
                .Select((fullString, index) => new { sb = new StringBuilder(fullString), index })
                .Select(row => new { row.index, sb = row.sb.Insert(row.index, char.ToUpper(row.sb[row.index])) })
                .Select(sb => sb.sb.Remove(sb.index + 1, 1))
                .Select(sb => sb.ToString())
                .Where(s => s.Any(c => char.IsUpper(c)))
                .ToList();


            // Source: CodeWars


            //return Enumerable.Range(0, s.Length)
            //    .Select(i => string.Concat(s.Select((x, y) => y == i ? char.ToUpper(x) : x)))
            //    .Where(x => x != s).ToList();
            //        }
        }
    }
}
