using System;
using System.Linq;

namespace ElephantTraining
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            var mass = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            Console.WriteLine(mass.Max() - mass.Min());
        }
    }
}