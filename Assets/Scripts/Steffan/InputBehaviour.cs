using UnityEngine;
using UnityEngine.Events;

namespace Steffan
{
	public class InputBehaviour : MonoBehaviour
	{
		public UnityEvent spaceResponse;
		// Update is called once per frame
		void Update () {
			if (Input.GetKeyDown(KeyCode.Space))
			{
				spaceResponse.Invoke();
			}
		}
	}
}
