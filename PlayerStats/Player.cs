namespace PlayerStats
{
    public class Player
    {
        private float _highScore;
        private int _playedGames;
        private int _wonGames;
        private string _name;

        public float HighScore
        {
            get
            {
                return _highScore;
            }
            set
            {
                if (HighScore > _highScore)
                {
                    _highScore = HighScore;
                }
            }
        }
        public string Name {get;}
    }
}