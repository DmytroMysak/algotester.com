using System;
using System.Collections.Generic;

namespace AplusB
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
        }
    }
}