using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Emmanuel.ScriptableObjects;
using JetBrains.Annotations;
using Matthew;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Steffan.Behaviours
{
    /// <summary>
    /// Turret Behaviour class. Handles attacking and target acquisition for the attached object.
    /// </summary>
    public class TurretBehaviour : MonoBehaviour
    {
        /// <summary>
        /// List of enemies in range of this turret
        /// </summary>
        private readonly List<EnemyDataBehaviour> _enemiesInRange = new List<EnemyDataBehaviour>();
        
        /// <summary>
        /// Reference to a turretData SO, containing all the HP and DMG values
        /// </summary>
        public TurretData turretData;

        /// <summary>
        /// Instantiate an SO for turretData. Target acquisition is set to the turretdata range.
        /// </summary>
        private void Start()
        {
            turretData = Instantiate(turretData);
            var hitbox = GetComponent< SphereCollider >();

            hitbox.radius = turretData.attackRange;
        }
        
        public Transform currentTarget;
        public Vector3 lastPosition;

        // Update is called once per frame
        /// <summary>
        /// Puts turret into attack mode if there are any enemies in range.
        /// </summary>
        private void Update()
        {
            if (_enemiesInRange.Count < 1)
                return;
            
            AttackMode();
            turretData.timeSinceLastShot += Time.deltaTime;
        }
        
        /// <summary>
        /// When enemy comes in range, it is added to the list of enemies in range
        /// </summary>
        /// <param name="enemy"> takes in the enemy that crossed the trigger </param>
        public void AddToEnemiesInRange(Object enemy)
        {
            var sender = enemy as GameObject;
            if (sender == null)
                return;

            var enemyBehaviour = sender.GetComponent<EnemyDataBehaviour>();
            if (enemyBehaviour == null)
                return;

            _enemiesInRange.Add(enemyBehaviour);
        }
        
        /// <summary>
        /// Removes an enemy from the list of nearby enemies when it leaves the range of turret
        /// </summary>
        /// <param name="enemy"> enemy that crossed the trigger </param>
        public void RemoveFromEnemiesInRange(Object enemy)
        {
            var sender = enemy as GameObject;
            if (sender == null)
                return;

            var enemyBehaviour = sender.GetComponent<EnemyDataBehaviour>();
            if (enemyBehaviour == null)
                return;
            if (!_enemiesInRange.Contains(enemyBehaviour))
                return;

            _enemiesInRange.Remove(enemyBehaviour);
        }

        /// <summary>
        /// Makes the turret always face its current target.
        /// </summary>
        private void LookAtTarget()
        {
            if (!_enemiesInRange.Any())
                return;
            
            // This is used to sort by NEAREST enemy. But also does some weird things and breaks the turret
            // Leave out for now.
            /*
            _enemiesInRange.Sort((x, y) =>
            {
                var pos = transform.position;
                var distance1 = Vector3.Distance(pos, x.transform.position);
                var distance2 = Vector3.Distance(pos, y.transform.position);
              return  distance1.CompareTo(distance2);
            });*/
            
            var current = _enemiesInRange[0];
            
            if ( current == null )
                return;
            lastPosition = current.transform.position;
            transform.LookAt(current.transform);
        }
        
        /// <summary>
        /// Looks at the target and calls the Fire function on it
        /// </summary>
        private void AttackMode()
        {
            LookAtTarget();
            if (!(turretData.timeSinceLastShot > turretData.attackRecharge)) return;
            Fire();
            turretData.timeSinceLastShot = 0;
        }
        
        /// <summary>
        /// Attacks the target.
        /// </summary>
        private void Fire()
        { 

            if ( _enemiesInRange[0].ed.health.Value > turretData.damage.Value )
            {
                _enemiesInRange[0].TakeDamage(turretData.Damage);
                return;
            }
            
            _enemiesInRange[0].TakeDamage(turretData.Damage);
            _enemiesInRange.RemoveAt(0);
        }
        
        /// <summary>
        /// If other is an enemy, add it to enemiesinrange list
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.CompareTag("enemy")) return;
            
            AddToEnemiesInRange(other.gameObject);
        }
        
        /// <summary>
        /// if other is an enemy, remove it from the enemiesinrange list
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerExit(Collider other)
        {
            if (!other.gameObject.CompareTag("enemy")) return;
            RemoveFromEnemiesInRange(other.gameObject);
        }
        
        /// <summary>
        /// On enemy death, remove it from the enemiesinrange list
        /// </summary>
        /// <param name="objs"></param>
        public void OnEnemyDeathEvent(Object[] objs)
        {
            var enemyGameObject = objs[0] as GameObject;
            var edBehaviour = objs[1] as EnemyDataBehaviour;

            if ( _enemiesInRange.Contains(edBehaviour) )
            {
                _enemiesInRange.Remove(edBehaviour);
            }
        }
    }
}