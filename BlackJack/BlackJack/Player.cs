namespace BlackJack
{
    public class Player : IPlayer
    {
        public int id { get; set; }
        public int Score { get; set; }
        public Player(int id)
        {
            this.id = id;
            Score = 0;
        }
    }
}