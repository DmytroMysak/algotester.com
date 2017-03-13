using System;
using System.Numerics;

namespace JohnTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ');
            BigInteger[] input = {BigInteger.Parse(data[0]), BigInteger.Parse(data[1]) };
            var inputModify = new[] {Modify(input[0].ToString()), Modify(input[1].ToString())};
            var sum = BigInteger.Zero;
            for (var i = input[0]; i <= input[1]; ++i)
            {
                var iModify = Modify(i.ToString());
                if (i >= input[0] && i <= input[1])
                {
                    ++sum;
                }
                if (iModify != i)// && iModify >= inputModify[0] && iModify <= inputModify[1])
                {
                    ++sum;
                }
            }
            Console.WriteLine(sum);
        }

        private static BigInteger Modify(string i)
        {
            if (i.Length <= 2) return BigInteger.Parse(i);
            var iModify = "";
            for (var j = 0; j <= i.Length / 2; ++j)
            {
                if (j == i.Length - j - 1)
                {
                    iModify += i[j].ToString();
                    break;
                }
                iModify += i[j] + i[i.Length - j - 1].ToString();
            }
            return BigInteger.Parse(iModify);
        }
    }
}