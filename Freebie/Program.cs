using System;
using System.Collections.Generic;

namespace Freebie
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine(new HashSet<string>(Console.ReadLine().Split(' ')).Count);
        }
    }
}