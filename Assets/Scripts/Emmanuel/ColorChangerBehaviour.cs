using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerBehaviour : MonoBehaviour
{
	public Color color;
	
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		gameObject.GetComponent<Renderer>().material.color = color;
	}
}
