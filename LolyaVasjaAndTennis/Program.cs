using System;

namespace LolyaVasjaAndTennis
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var whoWins = Console.ReadLine();
            var score = new[] {0, 0};
            var game = new[] {0, 0};
            for (var i = 0; i < n; ++i)
            {
                ++game[whoWins[i] == 'K' ? 0 : 1];
                if ((game[0] >= 11 || game[1] >= 11) && Math.Abs(game[0] - game[1]) >= 2)
                {
                    ++score[game[0] > game[1] ? 0 : 1];
                    game[0] = game[1] = 0;
                }
            }
            Console.WriteLine("{0}:{1}", score[0], score[1]);
            if (game[0] != 0 || game[1] != 0)
            {
                Console.WriteLine("{0}:{1}", game[0], game[1]);
            }
        }
    }
}