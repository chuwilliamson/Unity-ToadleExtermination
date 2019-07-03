using System;
using Emmanuel.ScriptableObjects;
using Matthew;
using UnityEngine;

namespace Steffan.Behaviours
{
	public class TakeDamageWhenHitByTongueBehaviour : MonoBehaviour
	{
		public string damagerTag = "tongue";

		public GameEvent OnTriggerEnterEvent;
		
		private EnemyDataBehaviour edBehaviour;

		public void Start()
		{
			edBehaviour = GetComponent< EnemyDataBehaviour >();
		}
		
		public void TakeTongueAttackDamage(GameObject player)
		{
			var playerData = player.GetComponent< PlayerDataBehaviour >();
			Debug.Log("TakeTongueAttackDamage:: PlayerDamage" + playerData.pd.Damage);
			playerData.Attack(edBehaviour);
		}

	}
}
