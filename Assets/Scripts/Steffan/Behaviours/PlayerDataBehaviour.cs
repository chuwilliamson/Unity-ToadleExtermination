using Emmanuel.ScriptableObjects;
using UnityEngine;

namespace Steffan.Behaviours
{
	public class PlayerDataBehaviour : MonoBehaviour
	{
		public PlayerData pd;
		
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

		public void GainCurrency(int amount)
		{
			pd.GainCurrency(amount);
		}
	}
}
