using System;

namespace InterestingCorrespondence
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = (int)Math.Sqrt(int.Parse(Console.ReadLine()));
            var s = Console.ReadLine();
            string resL = "",resR = "";

            for (int i = 0, ii = n - 1 ; i < n; ++i, --ii)
            {
                int x = i, xx = ii, y = 0, yy = n-1;
                for (int j = 0, jj = 0; x >= 0; ++j, ++jj)
                {
                    resL += s[y*n + x];
                    if (n -1 -yy != xx) resR = s[yy*n + xx] + resR;
                    ++y; --yy; --x; ++xx;
                }
            }
            Console.WriteLine(resL + resR);
        }
    }
}