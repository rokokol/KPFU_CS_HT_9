using System;
namespace HT
{
    public struct Player
    {
        private static readonly Random RANDOM = new Random();
        public readonly Countries country;

        public Player Battle(Player player)
        {
            if (RANDOM.Next(0, 2) == 1)
            {
                return this;
            }
            return player;
        }

        public override string ToString()
        {
            return country.ToString();
        }

        public Player(Countries country)
        {
            this.country = country;
        }
    }
}
