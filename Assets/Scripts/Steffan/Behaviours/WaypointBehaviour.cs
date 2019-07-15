using System;
using Emmanuel.ScriptableObjects;
using UnityEngine;

namespace Steffan.Behaviours
{
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
