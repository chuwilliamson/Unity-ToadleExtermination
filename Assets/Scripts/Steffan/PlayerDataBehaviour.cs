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
		void Update () {
		
		}
		
	}
}
