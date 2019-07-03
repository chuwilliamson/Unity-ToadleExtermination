using UnityEngine;

namespace Emmanuel.Behaviours
{
	public class EnemyHealthBarLookAtCameraBehaviour : MonoBehaviour
	{

		[SerializeField] private GameObject thisThing;
		// Use this for initialization
		void Start () 
		{

		}
	
		// Update is called once per frame
		void Update () 
		{
			transform.LookAt(thisThing.transform);	
		}
	}
}
