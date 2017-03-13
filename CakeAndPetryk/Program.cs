using System;

namespace CakeAndPetryk
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToDouble);
            Console.WriteLine("{0:0.####}", Math.Sqrt(input[1] * input[1] / input[0]));
        }
    }
}