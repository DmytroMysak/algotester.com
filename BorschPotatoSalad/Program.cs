using System;
using System.Collections.Generic;
using System.Linq;

namespace BorschPotatoSalad
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var friendWant = new List<long[]>();
            for (var i = 0; i < n; i++)
            {
                friendWant.Add(Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt64));
            }
            var avgA = friendWant.Average(t => t[0]);
            var avgB = friendWant.Average(t => t[1]);
            var avgC = friendWant.Average(t => t[2]);

            var res = friendWant.Aggregate(0.0, (cur, t) => (Math.Abs(avgA - t[0]) +
                                                             Math.Abs(avgB - t[1]) +
                                                             Math.Abs(avgC - t[2]) + cur));

            Console.WriteLine(res);

        }
    }
}