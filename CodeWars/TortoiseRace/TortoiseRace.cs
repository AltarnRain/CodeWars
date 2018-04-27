using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.TortoiseRace
{
    public class Tortoise
    {
        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;

            double totalSeconds = (double)g / (v2 - v1) * 3600;
            double h = Math.Floor(totalSeconds / 3600);
            double m = Math.Floor((totalSeconds / 60) - (h * 60));
            double s = Math.Floor(totalSeconds - (h * 3600) - (m * 60));

            return new int[] { (int)h, (int)m, (int)s };
        }
    }
}


//Solutions:
//     if (v1 >= v2) return null;
//    var t = TimeSpan.FromHours((double)g / (v2 - v1));
//    return new[] {t.Hours, t.Minutes, t.Seconds};


//    return v1 >= v2? null : Array.ConvertAll(TimeSpan.FromHours((g / (v2 - v1 + 0.0))).ToString().Split(':'), double.Parse).Select(d => (int) d).ToArray();  }

