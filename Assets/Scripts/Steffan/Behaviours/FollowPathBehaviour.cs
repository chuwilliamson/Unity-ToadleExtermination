using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Steffan.Behaviours
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	public class FollowPathBehaviour : MonoBehaviour
	{
		[Space(10)]
		[Header("[Readme] This causes the object to follow the given path of waypoints.")]
		[Space(10)]
		[Header("Assign gameobjects(Waypoints) to the list to have the object approach them in that order.")]
		public List<Transform> WaypointsToFollow;

		[Header("This is a list of gameobjects(Waypoints) that has been passed by the object.")]
		public List<Transform> WaypointsPassed;
		[Header("This is the teleport controller. " +
		        "Recommend creating a Teleporter game object with the TeleportBehaviour script")]
	
		public TeleportBehaviour Teleporter;

		public float speed = 5f;

		public MoveMethod movement;

		public bool loop;

		public List<Transform> SavedPath;

		public NavMeshAgent navmeshAgent;

		[Cinemachine.TagField] private string cmTagField;

		public enum MoveMethod 
		{
			IDLE,
			TRAVEL
		}

		private void Start()
		{
			movement = MoveMethod.TRAVEL;
			SavedPath = new List<Transform>(WaypointsToFollow);
			navmeshAgent = GetComponent<NavMeshAgent>();
		}

		void RestartPath()
		{
			WaypointsToFollow = new List<Transform>(SavedPath);
			transform.position = WaypointsToFollow[0].transform.position;
		}
		// Update is called once per frame
		void Update ()
		{
			if (WaypointsToFollow.Count < 1)
			{
				if (loop)
				{
					RestartPath();
				}
				return;
			}

			switch (movement)
			{
				case MoveMethod.TRAVEL:
					WaypointTravel();
					break;
				case MoveMethod.IDLE:
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	
		public void AddWaypointToFollow(Transform go)
		{
			WaypointsToFollow.Add(go);
		}
	
		private void AddWaypointPassed(Transform go)
		{
			WaypointsPassed.Insert(0, go);
		}
	
		private void OnTriggerEnter(Collider other)
		{
			if (!other.gameObject.CompareTag("Waypoint"))
				return;
			if (WaypointsToFollow.Count < 1)
			{
				return;
			}

			WaypointsToFollow.Remove(other.gameObject.transform);
			AddWaypointPassed(other.gameObject.transform);
		}

		public void WaypointTravel()
		{
			if (WaypointsToFollow.Count == 0)
				return;
			navmeshAgent.SetDestination(WaypointsToFollow[0].transform.position);

		}
		public void NextWaypointTeleport()
		{
			Teleporter.Teleport(WaypointsToFollow[0]);
		}

		public void ChangeMoveMethod(int val)
		{
			movement = (MoveMethod) val;
		}
	}
}
