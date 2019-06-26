using Emmanuel;
using UnityEngine;

namespace Steffan
{
	public class EnemyDataBehaviour : MonoBehaviour
	{
		public Emmanuel.EnemyData ed;
		// Use this for initialization
		void Start ()
		{
			ed = Instantiate(ed);
		}

		public void Attack(PlayerDataBehaviour other)
		{
			other.TakeDamage(ed.Damage);
		}

		public void TakeDamage(PlayerData playerData)
		{
			TakeDamage(playerData.Damage);
		}

		public void onTriggerEnterEventRaised(Object other)
		{
			
			var damager = ((GameObject)other).gameObject.GetComponent<PlayerDataBehaviour>();
			if ( damager == null )
				return;
			Debug.Log(damager.pd.Damage.ToString());
			damager.Attack(this);
		}
		public void TakeDamage(float dmgTaken)
		{
			ed.TakeDamage(dmgTaken);
		}
	}
}
