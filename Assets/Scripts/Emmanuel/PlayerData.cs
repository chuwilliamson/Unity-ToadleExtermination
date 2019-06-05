namespace Emmanuel
{
    public class PlayerData : Entity
    {
        public override float Attack(object other)
        {
            return base.Attack(other);
        }

        public override float TakeDamage(float dmg)
        {
            return base.TakeDamage(dmg);
        }

        public PlayerData(float health, float damage) : base(health, damage)
        {
        }
    }
}
