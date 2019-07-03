using System;
using Emmanuel.Interfaces;
using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Data/Entity")]
    public class Entity : MyScriptableObject, IAttackable, ITakeDamageable
    {
        [SerializeField] public FloatVar _health;
        [SerializeField] public FloatVar _damage;

        public Entity(string name, float health, float damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }



        public string Name { get; set; }

        public float Damage
        {
            get { return _damage.Value;} 
            set { _damage.Value = value; }
        }

        public float Health
        {
            get { return _health.Value; }
            set { _health.Value = value; }
        }

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
