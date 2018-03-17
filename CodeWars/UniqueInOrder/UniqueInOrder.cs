//Implement the function unique_in_order which takes as argument a sequence and 
//returns a list of items without any elements with the same 
//value next to each other and preserving the original order of elements.

namespace UniqueInOrder
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var returnValue = new List<T>();
            for (var i = 0; i < iterable.Count(); i++)
            {
                if (i == 0)
                {
                    returnValue.Add(l[i]);
                }
                else
                {
                    if (!l[i].Equals(l[i - 1]))
                    {
                        returnValue.Add(l[i]);
                    }
                }
            }

            return returnValue;
        }
    } 
}