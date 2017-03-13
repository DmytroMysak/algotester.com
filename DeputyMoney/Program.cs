using System;
using System.Collections.Generic;

namespace DeputyMoney
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt64(Console.ReadLine());
            var bills = new[] {500, 200, 100, 50, 20, 10, 5, 2, 1};
            var sum = 0;
            foreach (var bill in bills)
            {
                while (n >= bill)
                {
                    n -= bill;
                    ++sum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}