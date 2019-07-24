using System;
using Emmanuel.ScriptableObjects;
using Matthew;
using UnityEngine;

namespace Steffan.Behaviours
{
    public class PlayerDataBehaviour : MonoBehaviour
    {
        public GameEvent onFrogustusDead;
        public PlayerData pd;
        [SerializeField] private int hp;
        private bool frogustusIsAlive = true;

        // Use this for initialization
        private void Start()
        {
            pd = Instantiate(pd);
            pd.Health = hp;
        }

        public void Attack(EnemyDataBehaviour other)
        {
            other.TakeDamage(pd.Damage);
        }

        public void TakeDamage(float dmgTaken)
        {
            pd.TakeDamage(dmgTaken);
            if (pd.Health <= 0 && frogustusIsAlive)
            {
                frogustusIsAlive = false;
                onFrogustusDead.Raise();
            }
        }

        public void GainCurrency(int amount)
        {
            pd.GainCurrency(amount);
        }
    }
}