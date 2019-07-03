using System.Collections;
using System.Collections.Generic;
using Matthew;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class TESTCollisionEventBehaviour : MonoBehaviour
{
	[SerializeField] private GameEvent Event;
	// Use this for initialization
	void Start () 
	{
		
	}

	public void TriggerEventDetected()
	{
		Debug.Log("Event Detected");
	}
	
}
