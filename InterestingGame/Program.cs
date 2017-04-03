using System;
using System.Collections.Generic;

namespace InterestingGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var i = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var res = i[0] * i[1];
            Console.WriteLine(res % 2 == 0 ? "Dragon" : "Imp");
        }
    }
}