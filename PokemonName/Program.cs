using System;

namespace PokemonName
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var t = Console.ReadLine();
            var s = Console.ReadLine();
            var res = false;
            for (var i = 0; i < t.Length; i++)
            {
                if (t[i] != s[0] && t[i] != '?') continue;
                var ss = true;
                for (int j = 1, k = i + 1; j < s.Length; ++j, ++k)
                {
                    if (k != t.Length && (t[k] == s[j] || t[k] == '?')) continue;
                    ss = false;
                    break;
                }
                if (!ss) continue;
                res = true;
                break;
            }
            Console.WriteLine(res ? "YES" : "NO");
        }
    }
}