using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Data/Enemy")]
    public class EnemyData : Entity
    { 
        public int _value;
        public override float Attack(Entity other)
        {
            return other.TakeDamage(Damage);
        }

        public override float TakeDamage(float dmgTaken)
        {
            Health -= dmgTaken;
            return dmgTaken;
        }

        public EnemyData(string name, float health, float damage) : base(name, health, damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
    }

   
}

