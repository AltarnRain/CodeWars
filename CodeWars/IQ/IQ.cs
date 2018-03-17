namespace CodeWars.IQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IQ
    {
        public static int Test(string numbers)
        {
            var returnValue = -1;
            var a = numbers.Split(' ');
            var nList = new List<int>();
            for (var i = 0; i < a.Length; i++)
            {
                int n;
                if (int.TryParse(a[i], out n))
                {
                    nList.Add(n);
                }
            }
            var even = nList.Where(e => e % 2 == 0);
            var uneven = nList.Where(e => e % 2 > 0);

            int weirdNum = even.Count() > uneven.Count() ? uneven.First() : even.First();

            returnValue = nList.FindIndex(e => e == weirdNum) + 1;

            return returnValue;
        }
    }

    // Ook
    //using System;
    //using System.Linq;

    //public class IQ
    //{
    //    public static int Test(string numbers)
    //    {
    //        var ints = numbers.Split(' ').Select(int.Parse).ToList();
    //        var unique = ints.GroupBy(n => n % 2).OrderBy(c => c.Count()).First().First();
    //        return ints.FindIndex(c => c == unique) + 1;
    //    }
    //} 
}