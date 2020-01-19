namespace Parser1.Entities
{
    public class GameBet
    {
        public GameBet(double team_1, double team_2, double draw)
        {
            Team_1 = team_1;
            Team_2 = team_2;
            Draw = draw;
        }

        public double Team_1 { get; set; }

        public double Team_2 { get; set; }

        public double Draw { get; set; }
    }
}
