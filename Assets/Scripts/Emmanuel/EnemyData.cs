using UnityEngine;

namespace Emmanuel
{
    [CreateAssetMenu(menuName = "Data/Enemy")]
    public class EnemyData : Entity
    {
        public override float Attack(Entity other)
        {
            return base.Attack(other);
        }

        public override float TakeDamage(float dmg)
        {
            return base.TakeDamage(dmg);
        }

        public EnemyData(string name, float health, float damage) : base(name, health, damage)
        {
        }
    }

   
}

