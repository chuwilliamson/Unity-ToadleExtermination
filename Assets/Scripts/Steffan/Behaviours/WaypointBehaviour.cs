using System;
using Emmanuel.ScriptableObjects;
using UnityEngine;

namespace Steffan.Behaviours
{
	/// <summary>
	/// This behaviours sets the game object position to a given waypoint scriptable object
	/// </summary>
	public class WaypointBehaviour : MonoBehaviour
	{

		public Waypoint wp;
		// Use this for initialization
		void Start ()
		{
			wp.Point = transform.position;
		}

		private void Update()
		{
			wp.Point = transform.position;
		}
	}
}
