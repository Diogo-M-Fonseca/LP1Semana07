namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private int health;
        private string Name {get;}

        public int XP
        {
            get => xp;
            set
            {
                xp++;
            }
        }





    }
}