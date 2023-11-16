using System;
namespace HT
{
    public static class Game
    {
        private static void Win(Team team)
        {
            team.score += 1;
            Console.WriteLine($"{team.country} wins!");
        }

        public static void Beach(params Team[] teams)
        {
            bool win = false;
            for (int i = 1; i < 4; i++)
            {
                win = teams[0].team[0].Battle(teams[i].team[i]).country != teams[0].country;
                if (win)
                {
                    Win(teams[i]);
                    break;
                }
            }
            if (!win)
            {
                Win(teams[0]);
            }
        }


    }
}
