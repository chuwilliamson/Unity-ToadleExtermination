using Matthew;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Data/Player")]
    public class PlayerData : Entity
    {
        [SerializeField] private GameEvent playerDied;

        [FormerlySerializedAs("_position")] [SerializeField]
        private Waypoint position;

        public PlayerData(string name, float health, float damage) : base(name, health, damage)
        {
            Currency = 0;
            Name = name;
            Health = health;
            Damage = damage;
        }

        public int Currency { get; private set; }

        public override float Attack(Entity other)
        {
            return other.TakeDamage(Damage);
        }

        public override float TakeDamage(float dmgTaken)
        {
            Health -= dmgTaken;
            if ( Health <= 0 )
                playerDied.Raise();
            return dmgTaken;
        }

        public int GainCurrency(int amountGained)
        {
            Currency += amountGained;
            return amountGained;
        }

        public int SpendCurrency(int amountSpent)
        {
            amountSpent = amountSpent <= Currency ? amountSpent : 0;
            Currency -= amountSpent;
            return amountSpent;
        }
    }

    [CustomEditor(typeof( PlayerData ))]
    public class PlayerDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if ( !GUILayout.Button("TakeDamage") ) return;
            var mt = target as PlayerData;
            if ( mt != null ) mt.TakeDamage(25);
        }
    }
}