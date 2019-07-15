using System.Collections.Generic;
using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
	[CreateAssetMenu(menuName = "Turret/TurretDisplayData List")]
	public class TurretDisplayDataList : ScriptableObject 
	{
		public List< TurretDisplayData > turretDisplaydatas = new List< TurretDisplayData >();
	}
}
