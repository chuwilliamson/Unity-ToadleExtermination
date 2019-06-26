using Matthew;
using UnityEngine;

namespace Steffan
{
	public class TakeDamageWhenHitByTongueBehaviour : MonoBehaviour
	{
		public string damagerTag = "tongue";

		public GameEvent OnTriggerEnterEvent;

		private EnemyDataBehaviour edBehaviour;
		private void OnTriggerEnter(Collider other)
		{
			if (!other.gameObject.CompareTag(damagerTag))
				return;
			//when we enter this trigger
			//1. get a reference to playerdatabehaviour
			//2. invoke attack on the enemydatabehaviour reference
			var damager = other.gameObject.GetComponent<PlayerDataBehaviour>();
			Debug.Log(damager.pd.Damage.ToString());
		
			damager.Attack(edBehaviour);
		
		
			// TODO: This gameobject takes damage when the Tongue enters its collider
			// 6/25 :- 2:33:: Emmanuel-" Testing now "
		}
	}
}
