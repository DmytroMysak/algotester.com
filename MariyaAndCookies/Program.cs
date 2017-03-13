using System;
using System.Collections.Generic;

namespace MariyaAndCookies
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var allPack = Console.ReadLine().Split(' ');
            long sum = 0;
            for (var i = 0; i < N; i++)
            {
                sum += long.Parse(allPack[i]) - 1;
            }
            Console.WriteLine(sum);
        }
    }
}