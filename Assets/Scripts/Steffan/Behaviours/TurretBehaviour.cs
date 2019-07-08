using System;
using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using UnityEngine;

namespace Steffan.Behaviours
{
	public class TurretBehaviour : MonoBehaviour
	{
		public TurretData turretData;
		private List<EnemyDataBehaviour> enemiesInRange = new List<EnemyDataBehaviour>();
		public GameObject turretShot;

		private void Start()
		{
			turretData = Instantiate(turretData);
		}

		// Update is called once per frame
		void Update ()
		{
			AttackMode();
			turretData.timeSinceLastShot += Time.deltaTime;
		}

		public void AddToEnemiesInRange(UnityEngine.Object enemy)
		{
			var sender = enemy as GameObject;
			if (sender == null)
				return;

			var enemyBehaviour = sender.GetComponent<EnemyDataBehaviour>();
			if (enemyBehaviour == null)
				return;
			
			enemiesInRange.Add(enemyBehaviour);
		}
		public void RemoveFromEnemiesInRange(UnityEngine.Object enemy)
		{
			var sender = enemy as GameObject;
			if (sender == null)
				return;
			
			var enemyBehaviour = sender.GetComponent<EnemyDataBehaviour>();
			if (enemyBehaviour == null)
				return;
			if (!enemiesInRange.Contains(enemyBehaviour))
				return;
				
			enemiesInRange.Remove(enemyBehaviour);
		}
		public void LookAtTarget()
		{
			transform.LookAt(enemiesInRange[0].transform);
		}

		public void AttackMode()
		{
			LookAtTarget();
			if (turretData.timeSinceLastShot > turretData.attackRecharge)
			{
				Fire();
				turretData.timeSinceLastShot = 0;
			}
			
		}

		public GameObject Fire()
		{
			var thisShot = Instantiate(turretShot);
			return thisShot;
		}
	}
}
