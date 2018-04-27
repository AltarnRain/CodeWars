﻿
namespace CodeWars.TheSuperMarketQueue
{
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public static long QueueTime(int[] customers, int n)
        {
            //var availableTills = n;
            //var customersInQueue = customers.ToList();            
            //var totalTime = 0;
            //var customersAtTill = new List<int>();

            //while (customersInQueue.Count() > 0 || customersAtTill.Count() > 0)
            //{
            //    if (availableTills > 0 && customersInQueue.Count() > 0)
            //    {
            //        customersAtTill.AddRange(customersInQueue.Take(availableTills).ToList());
            //        customersInQueue.RemoveRange(0, availableTills < customersInQueue.Count() ? availableTills : customersInQueue.Count());
            //    }

            //    var minTime = customersAtTill.Min();
            //    for (var i = 0; i < customersAtTill.Count(); i++)
            //    {
            //        customersAtTill[i] = customersAtTill[i] - minTime;
            //    }

            //    customersAtTill = customersAtTill.Where(c => c > 0).Select(c => c).ToList();
            //    availableTills = n - customersAtTill.Count();
            //    totalTime += minTime;
            //}

            //return totalTime;
            var registers = new List<int>(Enumerable.Repeat(0, n));

            foreach (int cust in customers)
            {
                registers[registers.IndexOf(registers.Min())] += cust;
            }
            return registers.Max();

        }


    }
}
