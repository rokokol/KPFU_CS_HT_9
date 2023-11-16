namespace HT
{
    public class Team
    {
        public Countries country;
        public string name;
        public Player[] team;
        public int score;

        public Team(Countries country, string name, params Player[] team)
        {
            this.country = country;
            this.name = name;
            this.team = team;
        }

        public override string ToString()
        {
            return $"{country} - {name} - {score}";
        }
    }
}
