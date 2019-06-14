using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCursorBehaviour : MonoBehaviour
{
	[SerializeField] private GameObject cursor;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		rotateTowards(cursor.transform.position);
	}

	void rotateTowards(Vector3 to)
	{
		Quaternion _lookRotation = Quaternion.LookRotation((to - transform.position).normalized);
		
		transform.rotation = _lookRotation;
	}
}
