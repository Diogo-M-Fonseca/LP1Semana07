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

        public int Level
        {
            get => 1 + xp / 1000; //xp errado provavelmente
        }





    }
}