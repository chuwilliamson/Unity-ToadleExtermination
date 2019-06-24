using UnityEngine;

namespace Emmanuel
{
    [CreateAssetMenu(menuName = "Data/Player")]
    public class PlayerData : Entity
    {
        private int _currency = 0;
        [SerializeField] private Waypoint _position;
        public int Currency
        {
            get { return _currency; }
            set { _currency = value; }
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

        public int GainCurrency(int amountGained)
        {
            Currency += amountGained;
            return amountGained;
        }

        public int SpendCurrency(int amountSpent)
        {
            amountSpent = (amountSpent <= Currency) ? amountSpent : 0;
            Currency -= amountSpent;
            return amountSpent;
        }
        
        public PlayerData(string name, float health, float damage) : base(name, health, damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
    }
}
