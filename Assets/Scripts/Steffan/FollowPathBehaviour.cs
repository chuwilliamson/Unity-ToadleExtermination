using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPathBehaviour : MonoBehaviour
{
	[Space(10)]
	[Header("[Readme] This causes the object to follow the given path of waypoints.")]
	[Space(10)]
	[Header("Assign gameobjects(Waypoints) to the list to have the object approach them in that order.")]
	public List<GameObject> WaypointsToFollow;

	[Header("This is a list of gameobjects(Waypoints) that has been passed by the object.")]
	public List<GameObject> WaypointsPassed;
	[Header("This is the teleport controller. " +
	        "Recommend creating a Teleporter game object with the TeleportBehaviour script")]
	
	public TeleportBehaviour Teleporter;

	public float speed = 5f;

	public MoveMethod movement;

	public bool loop;

	public List<GameObject> SavedPath;

	public enum MoveMethod 
	{
		IDLE,
		TRAVEL
	}

	private void Start()
	{
		movement = MoveMethod.TRAVEL;
		SavedPath = new List<GameObject>(WaypointsToFollow);
	}

	void RestartPath()
	{
		WaypointsToFollow = new List<GameObject>(SavedPath);
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
	
	public void AddWaypointToFollow(GameObject go)
	{
		WaypointsToFollow.Add(go);
	}
	
	[SerializeField]
	private void AddWaypointPassed(GameObject go)
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

		WaypointsToFollow.Remove(other.gameObject);
		AddWaypointPassed(other.gameObject);
	}

	public void WaypointTravel()
	{
		transform.position = Vector3.MoveTowards(transform.position, WaypointsToFollow[0].transform.position, speed * Time.deltaTime);
	}
	public void NextWaypointTeleport()
	{
		Teleporter.Teleport(WaypointsToFollow[0].transform);
	}

	public void ChangeMoveMethod(int val)
	{
		movement = (MoveMethod) val;
	}
}
