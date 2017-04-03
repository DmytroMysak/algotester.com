using System;
namespace Teeth
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var k = long.Parse(Console.ReadLine().Split(' ')[1]);
            var a = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt64);
            long max = 0;
            long t = 0;
            foreach (var l in a)
            {
                if (l >= k)
                {
                    ++t;
                }
                else
                {
                    t = 0;
                }
                if (t > max)
                {
                    max = t;
                }
            }
            Console.WriteLine(max);
        }
    }
}