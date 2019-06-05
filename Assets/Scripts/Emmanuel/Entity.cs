using Assets.Scripts.Emmanuel;
using UnityEngine;

namespace Emmanuel
{
    public class Entity : ScriptableObject, IAttackable, ITakeDamageable
    {
        public Entity(string name, float health, float damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }
        protected float Damage { get; set; }

        protected float Health { get; set; }

        public virtual float TakeDamage(float dmg)
        {
            throw new System.NotImplementedException();
        }

        public virtual float Attack(Entity other)
        {
            throw new System.NotImplementedException();
        }
    }
}
