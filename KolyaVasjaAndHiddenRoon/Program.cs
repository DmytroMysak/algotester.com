using System;
using System.Collections.Generic;
using System.Linq;

namespace KolyaVasjaAndHiddenRoon
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            var s = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt64);//.OrderByDescending(c => c);
            Array.Sort(s, (a, c) => c.CompareTo(a));

            var dick = new SortedDictionary<long, long>();
            foreach (var elem in Console.ReadLine().Split(' '))
            {
                var i = Convert.ToInt64(elem);
                if (dick.ContainsKey(i))
                {
                    ++dick[i];
                    continue;
                }
                dick.Add(i, 1);
            }

            long sum = 0;
            for (var i = 0; i < s.Length;)
            {
                var key = dick.Keys.Last();
                var value = dick[key];
                for (var j = 0; j < value; ++j, ++i)
                {
                    sum += key * s[i];
                }
                dick.Remove(key);
                if (dick.ContainsKey(key - 1))
                {
                    dick[key - 1] += value;
                }
                else
                {
                    dick.Add(key - 1, value);
                }
            }
            Console.WriteLine(sum);
        }
    }
}