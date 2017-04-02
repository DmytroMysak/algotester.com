using System;
using System.Collections.Generic;
using System.Linq;

namespace MarichkaAndGoodSweet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine().Split(' ')[1]);
            var dick = new Dictionary<int, int>();
            foreach (var s in Console.ReadLine().Split(' '))
            {
                var i = int.Parse(s);
                if (dick.ContainsKey(i))
                {
                    ++dick[i];
                }
                else
                {
                    dick.Add(i, 1);
                }
            }

            if (dick.Values.Max() >= input)
            {
                foreach (var i in dick)
                {
                    for (var j = 0; j < i.Value; j++)
                    {
                        Console.Write(i.Key + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Oh sh*t");
            }

        }
    }
}