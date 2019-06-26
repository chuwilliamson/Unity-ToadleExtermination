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

		private void Start()
		{
			turretData = Instantiate(turretData);
		}

		// Update is called once per frame
		void Update () {
		
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
		public bool AcquireTarget()
		{
			return false;
		}
		public bool LookAtTarget()
		{
			return false;
		}
	}
}
