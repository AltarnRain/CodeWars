
namespace CodeWars.CountSmilyFaces
{
    using System.Linq;
    public static class Kata
    {
        public static int CountSmileys(string[] smileys)
        {
            var eyes = new char[] { ':', ';' };
            var nose = new char[] { '-', '~' };
            var mouth = new char[] { ')', 'D' };
            var numberOfSmilies = 0;
            foreach (var s in smileys)
            {
                switch (s.Length)
                {
                    case 2:
                        if (eyes.Contains(s[0]) && mouth.Contains(s[1])) numberOfSmilies++;
                        break;
                    case 3:
                        if (eyes.Contains(s[0]) && nose.Contains(s[1]) && mouth.Contains(s[2])) numberOfSmilies++;
                        break;
                }
            }

            return numberOfSmilies;
        }
    }
}