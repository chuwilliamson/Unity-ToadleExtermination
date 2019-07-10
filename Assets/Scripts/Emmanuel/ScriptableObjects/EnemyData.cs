using UnityEngine;
using UnityEngine.Serialization;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Data/Enemy")]
    public class EnemyData : Entity
    {
        [FormerlySerializedAs("_value")] public int value;

        public EnemyData(string name, float health, float damage) : base(name, health, damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public override float Attack(Entity other)
        {
            return other.TakeDamage(Damage);
        }

        public override float TakeDamage(float dmgTaken)
        {
            Health -= dmgTaken;
            return dmgTaken;
        }
    }
}