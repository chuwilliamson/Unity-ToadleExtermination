using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TadpoleShotBehaviour : MonoBehaviour
{
	private float lifetime;
	// Use this for initialization
	void Start ()
	{
		lifetime = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += Vector3.forward;
		
		lifetime += Time.deltaTime;
		if (lifetime >= 1) {Destroy(gameObject);} 
	}
}
