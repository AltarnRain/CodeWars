//using System;
//using System.Linq;

//public class Scramblies
//{

//    public static bool Scramble(string str1, string str2)
//    {
//        var scambled = from c in str1.Distinct()
//                     select new { c, count = str1.Count(c2 => c2 == c) };

//        var sorted = from c in str2.Distinct()
//                        select new { c, count = str2.Count(c2 => c2 == c) };


//        return sorted.All(x => x.c ) 
//        }

//}