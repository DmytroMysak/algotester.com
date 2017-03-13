using System;
using System.Text.RegularExpressions;

namespace HelpOrNot
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var k = Convert.ToInt32(Console.ReadLine());
            var count = Regex.Matches(Regex.Escape(Console.ReadLine()), "TOILET").Count;
            Console.WriteLine(k == count ? "YES" : "NO");
        }
    }
}