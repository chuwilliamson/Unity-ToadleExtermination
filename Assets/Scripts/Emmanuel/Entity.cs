using Assets.Scripts.Emmanuel;
using UnityEngine;

namespace Emmanuel
{
    [CreateAssetMenu(menuName = "Data/Entity")]
    public class Entity : MyScriptableObject, IAttackable, ITakeDamageable
    {
        [SerializeField] private FloatVar _health;

        public Entity(string name, float health, float damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        
        public string Name { get; set; }
        public float Damage { get; set; }

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
