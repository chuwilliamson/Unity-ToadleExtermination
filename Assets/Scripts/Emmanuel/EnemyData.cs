using UnityEngine;

namespace Emmanuel
{
    [CreateAssetMenu(menuName = "Data/Enemy")]
    public class EnemyData : Entity
    {
        public override float Attack(Entity other)
        {
            return other.TakeDamage(Damage);
        }

        public override float TakeDamage(float dmgTaken)
        {
            Health -= dmgTaken;
            return Damage;
        }

        public EnemyData(string name, float health, float damage) : base(name, health, damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
    }

   
}

