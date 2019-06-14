using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TeleportBehaviour : MonoBehaviour {
	[Header("This is the target destination for the teleporting object.")]
	public Transform targetPosition;
	[Header("This is the object that will be teleported to the destination.")]
	public Transform sourceObject;

	public void Teleport()
	{
		sourceObject.position = targetPosition.position;
	}
	
	public void Teleport(Transform target)
	{
		sourceObject = target;
	}
}
