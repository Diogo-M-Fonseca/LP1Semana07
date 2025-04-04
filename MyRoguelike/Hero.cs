namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private int health;
        private string Name {get;}


        public Hero(string name)
        {
            Name = name;
            xp = 0;
            Health = (int)MaxHealth;
        }

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
            get => 1 + XP / 1000; //xp errado provavelmente
        }

        public int Health 
        {
            get => health;
            set //provavelmente consigo juntar este set com o get
            {
                if (health < 0) // verificar se é o Health certo
                {
                    health = 0;
                }
                else if (health > MaxHealth)
                {
                    health = (int)MaxHealth; // pode haver problemas com a conv
                }
            }
        }

        public float MaxHealth 
        {
            get => 100 + (Level - 1) * 20;
        }

        public void TakeDamage(float damage)
        {
            health -= (int)damage;
            xp += (int)damage/20;
        }





    }
}