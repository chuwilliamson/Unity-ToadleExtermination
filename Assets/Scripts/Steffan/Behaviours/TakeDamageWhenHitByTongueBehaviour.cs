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

		public void OnAddedToContactList(UnityEngine.Object[] obj)
		{
			var sender = obj[0] as PlayerDataBehaviour;//sent from when the player adds this object to the contact list
			var defender = obj[1];
			if ( sender == null ) return;
			if ( defender == null || defender != gameObject )
				return;
			sender.Attack(edBehaviour);
		}
		public void TakeTongueAttackDamage(UnityEngine.Object[] obj)
		{
			var sender = obj[0] as PlayerDataBehaviour;//sent from when the player adds this object to the contact list
			var defender = obj[1];
			if ( sender == null ) return;
			if ( defender == null || defender != gameObject )
				return;
			sender.Attack(edBehaviour);
		}
	}
}
