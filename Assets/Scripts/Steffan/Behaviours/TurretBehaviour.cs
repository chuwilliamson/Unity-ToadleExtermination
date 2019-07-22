using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Emmanuel.ScriptableObjects;
using Matthew;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Steffan.Behaviours
{
    public class TurretBehaviour : MonoBehaviour
    {
        private readonly List<EnemyDataBehaviour> _enemiesInRange = new List<EnemyDataBehaviour>();
        public TurretData turretData;
        public GameObject turretShot;

        private void Start()
        {
            turretData = Instantiate(turretData);
            var hitbox = GetComponent< SphereCollider >();

            hitbox.radius = turretData.attackRange;
        }

        public Transform currentTarget;
        public Vector3 lastPosition;

        // Update is called once per frame
        private void Update()
        {
            if (_enemiesInRange.Count < 1)
                return;
            
            AttackMode();
            turretData.timeSinceLastShot += Time.deltaTime;
        }

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

        
        private void LookAtTarget()
        {
            _enemiesInRange.Sort((x, y) =>
            {
                var pos = transform.position;
                var distance1 = Vector3.Distance(pos, x.transform.position);
                var distance2 = Vector3.Distance(pos, y.transform.position);
              return  distance1.CompareTo(distance2);
            });
            var current = _enemiesInRange[0];
            
            if ( current == null )
                return;
            lastPosition = current.transform.position;
            transform.LookAt(current.transform);
        }

        private void AttackMode()
        {
            LookAtTarget();
            if (!(turretData.timeSinceLastShot > turretData.attackRecharge)) return;
            Fire();
            turretData.timeSinceLastShot = 0;
        }

        private void Fire()
        {

            if ( _enemiesInRange[0].ed.health.Value > turretData.damage.Value )
            {
                _enemiesInRange[0].TakeDamage(turretData.Damage);
                return;
            }
            
            _enemiesInRange[0].TakeDamage(turretData.Damage);
            //Destroy(_enemiesInRange[0].gameObject);  
            _enemiesInRange.RemoveAt(0);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.CompareTag("enemy")) return;
            
            AddToEnemiesInRange(other.gameObject);
        }

        private void OnTriggerExit(Collider other)
        {
            if (!other.gameObject.CompareTag("enemy")) return;
            RemoveFromEnemiesInRange(other.gameObject);
        }

        public void OnEnemyDeathEvent(Object[] objs)
        {
            var enemyGameObject = objs[0] as GameObject;
            var edBehaviour = objs[1] as EnemyDataBehaviour;

            if ( _enemiesInRange.Contains(edBehaviour) )
            {
                _enemiesInRange.Remove(edBehaviour);
                Destroy(enemyGameObject);
            }
        }
    }
}