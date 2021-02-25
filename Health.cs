

namespace MyGame{

    public class Health
    {
        public int health = 1;
        public int maxHealth = 5;

        public float CurrentHealthPercent()
        {
            return (float)health/maxHealth * 100;
        }

        public virtual void RestoreHealth()
        {
            health = maxHealth;
        }
    }
}