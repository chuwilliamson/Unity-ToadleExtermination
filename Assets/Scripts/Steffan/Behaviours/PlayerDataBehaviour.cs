using System;
using Emmanuel.ScriptableObjects;
using Matthew;
using UnityEngine;

namespace Steffan.Behaviours
{
    /// <summary>
    /// Handles the logic for the PlayerData SO. Attach to player object.
    /// </summary>
    public class PlayerDataBehaviour : MonoBehaviour
    {
        /// <summary>
        /// Event called when Frogustus dies.
        /// </summary>
        public GameEvent onFrogustusDead;
        
        /// <summary>
        /// Reference to PlayerData SO
        /// </summary>
        public PlayerData pd;
        
        /// <summary>
        /// Used to set starting hp.
        /// </summary>
        [SerializeField] private int hp;
        
        /// <summary>
        /// Boolean that keeps track of whether or not Frogustus is alive.
        /// </summary>
        private bool frogustusIsAlive = true;

        
        // Use this for initialization
        /// <summary>
        /// Instantiate the player and set the data SO with the values given on this object.
        /// </summary>
        private void Start()
        {
            pd = Instantiate(pd);
            pd.Health = hp;
        }
        
        /// <summary>
        /// Calls the other object's takeDamage function 
        /// </summary>
        /// <param name="other"></param>
        public void Attack(EnemyDataBehaviour other)
        {
            other.TakeDamage(pd.Damage);
        }
        
        /// <summary>
        /// Reduce HP by a given value
        /// </summary>
        /// <param name="dmgTaken">damage value</param>
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