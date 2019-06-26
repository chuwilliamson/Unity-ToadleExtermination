using Emmanuel;
using UnityEngine;

namespace Steffan
{
	public class PlayerDataBehaviour : MonoBehaviour
	{
		public Emmanuel.PlayerData pd;
		
		// Use this for initialization
		void Start ()
		{
			pd = Instantiate(pd);
		}
	
		// Update is called once per frame
		void Update () 
		{
		
		}
		public void Attack(EnemyDataBehaviour other)
		{
			other.TakeDamage(pd.Damage);
		}
		
		public void TakeDamage(float dmgTaken)
		{
			pd.TakeDamage(dmgTaken);
		}
	}
}
