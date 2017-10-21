using System;

namespace LvivTower
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt64);
            var R = input[0];
            var h = input[1];
            var d = Math.Sqrt(h * (2 * R + h));
            var cosd = (R * R + (R + h) * (R + h) - d * d) / (2 * R * (R + h));
            var square = 2 * Math.PI * R * R * (1 - cosd);
            Console.WriteLine(square);
        }
    }
}