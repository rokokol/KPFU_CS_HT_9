using System;

namespace HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to our game!");
            Team russia = new Team(Countries.Russia, "Rus", new Player(Countries.Russia),
                new Player(Countries.Russia), new Player(Countries.Russia), new Player(Countries.Russia),
                new Player(Countries.Russia), new Player(Countries.Russia), new Player(Countries.Russia),
                new Player(Countries.Russia), new Player(Countries.Russia), new Player(Countries.Russia),
                new Player(Countries.Russia), new Player(Countries.Russia), new Player(Countries.Russia),
                new Player(Countries.Russia), new Player(Countries.Russia), new Player(Countries.Russia));

            Team china = new Team(Countries.China, "Chn", new Player(Countries.China),
                new Player(Countries.China), new Player(Countries.China), new Player(Countries.China),
                new Player(Countries.China), new Player(Countries.China), new Player(Countries.China),
                new Player(Countries.China), new Player(Countries.China), new Player(Countries.China),
                new Player(Countries.China), new Player(Countries.China), new Player(Countries.China),
                new Player(Countries.China), new Player(Countries.China), new Player(Countries.China));

            Team france = new Team(Countries.France, "Frn", new Player(Countries.France),
                new Player(Countries.France), new Player(Countries.France), new Player(Countries.France),
                new Player(Countries.France), new Player(Countries.France), new Player(Countries.France),
                new Player(Countries.France), new Player(Countries.France), new Player(Countries.France),
                new Player(Countries.France), new Player(Countries.France), new Player(Countries.France),
                new Player(Countries.France), new Player(Countries.France), new Player(Countries.France));

            Team kazakhstan = new Team(Countries.Kazakhstan, "Kzn", new Player(Countries.Kazakhstan),
                new Player(Countries.Kazakhstan), new Player(Countries.Kazakhstan), new Player(Countries.Kazakhstan),
                new Player(Countries.Kazakhstan), new Player(Countries.Kazakhstan), new Player(Countries.Kazakhstan),
                new Player(Countries.Kazakhstan), new Player(Countries.Kazakhstan), new Player(Countries.Kazakhstan),
                new Player(Countries.Kazakhstan), new Player(Countries.Kazakhstan), new Player(Countries.Kazakhstan),
                new Player(Countries.Kazakhstan), new Player(Countries.Kazakhstan), new Player(Countries.Kazakhstan));

            Game.Beach(russia, france, china, kazakhstan);
        }
    }
}
