namespace Emmanuel.ScriptableObjects
{
    public class TurretData : Entity
    {
        private float cost;
        
        public TurretData(string name, float health, float damage) : base(name, health, damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public void Deploy()
        {
            
        }
        
    }
}
