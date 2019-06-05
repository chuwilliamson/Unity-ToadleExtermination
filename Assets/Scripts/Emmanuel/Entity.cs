using Assets.Scripts.Emmanuel;
using UnityEngine;

namespace Emmanuel
{
    public class Entity : ScriptableObject, IAttackable, ITakeDamageable
    {
        public Entity(float health, float damage)
        {
            Health = health;
            Damage = damage;
        }

        protected float Damage { get; set; }

        protected float Health { get; set; }


        public virtual float Attack(object other)
        {
            throw new System.NotImplementedException();
        }

        public virtual float TakeDamage(float dmg)
        {
            throw new System.NotImplementedException();
        }
    }
}
