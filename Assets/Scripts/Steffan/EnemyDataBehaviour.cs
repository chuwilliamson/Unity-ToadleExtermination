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
	
		// Update is called once per frame
		void Update () {
		
		}
	}
}
