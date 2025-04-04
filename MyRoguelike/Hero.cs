namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private int health;
        public string Name {get;}


        public Hero(string name)
        {
            Name = name;
            xp = 0;
            health = (int)MaxHealth;
        }

        public int XP
        {
            get => xp;
            set
            {
                xp = value;
            }
        }

        public int Level
        {
            get => 1 + XP / 1000; 
        }

        public int Health 
        {
            get => health;
            set 
            {
                health = value;
                if (Health <= 0) 
                {
                    health = 0;
                }
                else if (Health > MaxHealth)
                {
                    health = (int)MaxHealth; 
                }
            }
        }

        public float MaxHealth 
        {
            get => 100 + (Level - 1) * 20;
        }

        public void TakeDamage(float damage)
        {
            Health -= (int)damage;
            XP += (int)damage/20;
        }





    }
}