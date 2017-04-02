using System;
using System.Collections.Generic;
using System.Linq;

namespace MizhlokatsiynyyExpress
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            var isFind = false;
            var res = "Hooray!\n";
            for (var i = 0; i < n; ++i)
            {
                list.Add(Console.ReadLine());
                if (isFind || (!list[i].Contains("FF") && !list[i].Contains("F|F"))) continue;
                isFind = true;
                var t = list[i].EndsWith("FF") ? new int[2]{3, 4} :
                    (list[i].StartsWith("FF") ? new int[2] {1, 2} : new int[2] {2, 3});
                res += (i + 1).ToString() + t[0] + " " + (i + 1) + t[1];
            }
            Console.WriteLine(isFind ? res : "No");
        }
    }
}