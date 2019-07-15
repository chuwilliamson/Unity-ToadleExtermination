using System;
using Emmanuel.Interfaces;
using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Data/Entity")]
    public class Entity : MyScriptableObject, IAttackable, ITakeDamageable
    {
        public FloatVar damage;
        public FloatVar health;

        public Entity(string name, float health, float damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get { return name; } set { ; } }

        public float Damage { get { return damage.Value; } protected set { damage.Value = value; } }

        public float Health { get { return health.Value; } set { health.Value = value; } }

        public virtual float Attack(Entity other)
        {
            throw new NotImplementedException();
        }

        public virtual float TakeDamage(float dmg)
        {
            throw new NotImplementedException();
        }
    }
}