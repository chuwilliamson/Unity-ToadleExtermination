using UnityEngine;

namespace Steffan.ScriptableObjects
{
	[CreateAssetMenu(menuName = "Data/Turret")]
	public class TurretData : Emmanuel.ScriptableObjects.MyScriptableObject

	{
		public float damageValue;
		public float attackRange;
		public float attackRecharge;
	}
}
