using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace KolyaVasjaAndHiddenRoon
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            var doors = new SortedDictionary<ulong, ulong>();
            var brushes = new SortedDictionary<ulong, ulong>();

            var input0 = Console.ReadLine().Split(' ');
            foreach (var elem in input0)
            {
                var i = ulong.Parse(elem);
                if (doors.ContainsKey(i))
                {
                    ++doors[i];
                    continue;
                }
                doors.Add(i, 1);
            }
            var input2 = Console.ReadLine().Split(' ');
            foreach (var elem in input2)
            {
                var i = ulong.Parse(elem);
                if (brushes.ContainsKey(i))
                {
                    ++brushes[i];
                    continue;
                }
                brushes.Add(i, 1);
            }

            BigInteger sum = 0;
            while (doors.Count > 0)
            {
                var door = doors.Keys.Last();
                var brush = brushes.Keys.Last();
                sum += new BigInteger(door) * new BigInteger(brush);
                if (doors[door] > 1)
                {
                    doors[door] -= 1;
                }
                else
                {
                    doors.Remove(door);
                }
                if (brushes[brush] > 1)
                {
                    brushes[brush] -= 1;
                }
                else
                {
                    brushes.Remove(brush);
                }
                if (brushes.ContainsKey(brush - 1))
                {
                    brushes[brush - 1] += 1;
                }
                else
                {
                    brushes.Add(brush - 1, 1);
                }
            }
            Console.WriteLine(sum);
        }
    }
}