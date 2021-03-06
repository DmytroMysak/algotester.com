﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace BorschPotatoSalad
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToDouble(Console.ReadLine());
            var friendWant = new List<double[]>();
            for (var i = 0; i < n; i++)
            {
                friendWant.Add(Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToDouble));
            }
            var sumA = friendWant.Sum(t => t[0]);
            var sumB = friendWant.Sum(t => t[1]);
            var sumC = friendWant.Sum(t => t[2]);
            var avrA1 = Math.Truncate(sumA / n);
            var avrB1 = Math.Truncate(sumB / n);
            var avrC1 = Math.Truncate(sumC / n);
            var avrA2 = Math.Truncate(sumA / (n + 1));
            var avrB2 = Math.Truncate(sumB / (n + 1));
            var avrC2 = Math.Truncate(sumC / (n + 1));

            var resA1 = friendWant.Aggregate(0.0, (cur, t) => Math.Abs(avrA1 - t[0]) + cur);
            var resB1 = friendWant.Aggregate(0.0, (cur, t) => Math.Abs(avrB1 - t[1]) + cur);
            var resC1 = friendWant.Aggregate(0.0, (cur, t) => Math.Abs(avrC1 - t[2]) + cur);
            var resA2 = friendWant.Aggregate(0.0, (cur, t) => Math.Abs(avrA2 - t[0]) + cur);
            var resB2 = friendWant.Aggregate(0.0, (cur, t) => Math.Abs(avrB2 - t[1]) + cur);
            var resC2 = friendWant.Aggregate(0.0, (cur, t) => Math.Abs(avrC2 - t[2]) + cur);
            var A = new BigInteger(resA1);
            var B = new BigInteger(resB1);
            var C = new BigInteger(resC1);
            Console.WriteLine((Math.Min(resA1, resA2) + Math.Min(resB1, resB2) + Math.Min(resC1, resC2)));
//            Console.WriteLine(A + B + C);
        }
    }

}
