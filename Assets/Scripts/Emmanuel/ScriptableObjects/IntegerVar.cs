using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
	[CreateAssetMenu(menuName = "Variables/int")]
	public class intVariable : MyScriptableObject
	{

		[SerializeField] private int value;

		public int Value
		{
			get { return value; }
			set { this.value = value; }
		}
	}
}
