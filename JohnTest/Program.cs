using System;
using System.Linq;
using System.Text;

namespace JohnTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var scope = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt64);
            var count = scope[1] + 1 - scope[0];
//            if(scope[1] > 101) count += scope[1] + 1 - (scope[0] < 101 ? 101 : scope[0]);
            for (var i = scope[0] < 101 ? 101 : scope[0]; i <= scope[1]; ++i)
            {
                var number = i.ToString();
//                if (number.Substring(1).Distinct().Count() == 1)
//                {
//                    --count;
//                }
                var left = number.Where((str, ix) => ix % 2 == 0)
                    .Aggregate(new StringBuilder(), (seed, c) => seed.Append(c)).ToString();
                var right = number.Where((str, ix) => ix % 2 == 1).Reverse();
                right = number.Length % 2 == 1
                    ? right.Reverse().Aggregate(new StringBuilder(), (seed, c) => seed.Append(c)).ToString()
                    : right.Aggregate(new StringBuilder(), (seed, c) => seed.Append(c)).ToString();
                var modify = int.Parse(left + right);
                if (modify != i || (modify < scope[0] || modify > scope[1]))
                {
                    ++count;
                }
            }
            Console.WriteLine(count);
        }
    }
}

//using System;
//using System.Text;
//
//namespace JohnTest
//{
//    internal class Program
//    {
//        private static long Modify(string normalNumber)
//        {
//            var left = new StringBuilder();
//            var right = new StringBuilder();
//
//            for (var i = 0; i < normalNumber.Length - 1; i = i + 2)
//            {
//                left.Append(normalNumber[i]);
//                right.Insert(0, normalNumber[i + 1]);
//            }
//            if (normalNumber.Length % 2 != 0)
//            {
//                left.Append(normalNumber[normalNumber.Length - 1]);
//            }
//            return Convert.ToInt64(left.ToString() + right.ToString());
//        }
//
//        public static void Main(string[] args)
//        {
//            var scope = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt64);
//            var count = scope[1] + 1 - (scope[0] < 0 ? 0 : scope[0]);
//            for (var i = scope[0] < 101 ? 101 : scope[0]; i <= scope[1]; ++i)
//            {
//                var modify = Modify(i.ToString());
//                if (modify < scope[0] || modify > scope[1])
//                {
//                    ++count;
//                }
//            }
//            Console.WriteLine(count);
//        }
//    }
//}