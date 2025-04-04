namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;
        public string Name {get;}

        public Player(string name)
        {
            Name = name;
            playedGames = 0;
            wonGames = 0;
            highScore = 0;
        }


       public float HighScore
        {
            get => highScore;
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }
        public float WinRate
        {
            get
            {

                if (playedGames > 0)
                {
                    return (float)wonGames / playedGames;
                }
                else
                {
                    return 0;
                }

            }

        }
        public void PlayGame(bool win)
        {
            playedGames++;
            if (win)
            {
                wonGames++;
            }
        }
    }
}