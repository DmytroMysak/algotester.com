using System;

namespace WhereRun
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToDouble);
            var t1 = input[0] / 2.0;
            var t2 = input[1] * 2.0;
            Console.WriteLine(t1 < t2 ? "Down" : (!Equals(t1, t2) ? "Up" : "Never mind"));
        }
    }
}