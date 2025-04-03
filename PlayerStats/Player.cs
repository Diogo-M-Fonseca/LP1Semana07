namespace PlayerStats
{
    public class Player
    {
        private float _highScore;
        private int _playedGames;
        private int _wonGames;
        private readonly string _name;

        public Player(string name)
        {
            _name = name;
            _playedGames = 0;
            _wonGames = 0;
            _highScore = 0;
        }


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
        public float WinRate
        {
            get
            {
                return WinRate;
            }
            set
            {
                WinRate = _playedGames / _wonGames;
            }
        }
        public void PlayGame(bool win)
        {
            _playedGames++;
            if (win == true)
            {
                _wonGames++;
            }
        }
    }
}