using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using UnityEngine;

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
        }

        // Update is called once per frame
        private void Update()
        {
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
            if (_enemiesInRange.Count < 1)
                return;
            transform.LookAt(_enemiesInRange[0].transform);
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
            Instantiate(turretShot);
        }
    }
}