using System;
using System.Collections.Generic;
using System.Linq;

namespace VerkhovnaRada
{
    internal class Program
    {
        private static ulong Gcd(IEnumerable<ulong> numbers)
        {
            return numbers.Aggregate(Gcd);
        }
        private static ulong Gcd(ulong a, ulong b)
        {
            return b == (ulong)0 ? a : Gcd(b, a % b);
        }
        public static void Main(string[] args)
        {
            Console.ReadLine();
            var votes = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToUInt64);
            var gcd = Gcd(votes);
            Console.WriteLine(votes.Aggregate((ulong) 0, (cur, t) => cur + t / gcd));
        }
    }
}