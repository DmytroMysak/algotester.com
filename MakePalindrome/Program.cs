using System;
using System.Collections.Generic;
using System.Linq;

namespace MakePalindrome
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var diffLetter = new Dictionary<char, uint>();
            var s = Console.ReadLine();
            foreach (var letter in s)
            {
                if (diffLetter.ContainsKey(letter))
                {
                    diffLetter[letter] += 1;
                }
                else
                {
                    diffLetter.Add(letter, 1);
                }
            }
            var count = diffLetter.Count(t => t.Value % 2 != 0);
            if ((s.Length % 2 == 0 && count == 0) || (s.Length % 2 != 0 && count == 1))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}