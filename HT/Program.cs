using System;

namespace HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to our game!");
            Console.WriteLine();

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

            Team[] teams = { russia, china, france, kazakhstan };
            Console.WriteLine("Beach:");
            Game.Beach(russia, france, china, kazakhstan);
            Console.WriteLine();

            Console.WriteLine("Mousetrap:");
            Game.Mousetrap(russia, france, china, kazakhstan);
            Console.WriteLine();

            Console.WriteLine("Sea:");
            Game.Sea(russia, france, china, kazakhstan);
            Console.WriteLine();

            Console.WriteLine("Fishing:");
            Game.Fishing(russia, france, china, kazakhstan);
            Console.WriteLine();

            Console.WriteLine("Postman:");
            Game.Postman(russia, france, china, kazakhstan);
            Console.WriteLine();

            Console.WriteLine("Slide:");
            Game.Slide(russia, france, china, kazakhstan);
            Console.WriteLine();

            Console.WriteLine("The Best Game Ever:");
            Game.TheBestGameEver(russia, france, china, kazakhstan);
            Console.WriteLine();

            Console.WriteLine("Wellcome teams!!!");
            Team win = russia;
            foreach (var t in teams)
            {
                if (t.score > win.score)
                {
                    win = t;
                }
                Console.WriteLine(t);
            }
            Console.WriteLine();

            Console.WriteLine("The champion is:");
            Console.WriteLine(win);

            Console.WriteLine();
            Console.WriteLine("Thank you for watching!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
