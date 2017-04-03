using System;

namespace SummerSchool
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var nk = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            var team = new int[nk[1]];
            var sum = nk[1];
            for (var i = 0; sum < nk[0]; ++i)
            {
                if (i == nk[1])
                {
                    i = 0;
                }
                if (team[nk[1] - 1] == 2)
                {
                    break;
                }
                ++sum;
                ++team[i];
            }
            if (sum != nk[0])
            {
                Console.WriteLine("Impossible");
            }
            else
            {
                foreach (var t in team)
                {
                    Console.Write(t + 1 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}