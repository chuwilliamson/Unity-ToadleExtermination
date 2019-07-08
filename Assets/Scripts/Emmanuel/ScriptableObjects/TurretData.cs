using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Data/Turret")]
    public class TurretData : Entity
    {
        [SerializeField]
        private float cost;
        
        public float attackRange;
        public float attackRecharge;
        public float timeSinceLastShot;
        public TurretData(string name, float health, float damage) : base(name, health, damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public void Deploy()
        {
            
        }
    }
}
