using UnityEngine;

namespace Emmanuel
{
    [CreateAssetMenu(menuName = "Data/Player")]
    public class PlayerData : Entity
    {
        public override float Attack(Entity other)
        {
            return base.Attack(other);
        }

        public override float TakeDamage(float dmg)
        {
            return base.TakeDamage(dmg);
        }

        public PlayerData(string name, float health, float damage) : base(name, health, damage)
        {
        }
    }
}
