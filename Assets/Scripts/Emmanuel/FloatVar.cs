using System.Collections;
using System.Collections.Generic;
using Emmanuel;
using UnityEngine;


[CreateAssetMenu(menuName = "Variables/float")]
public class FloatVar : MyScriptableObject
{
	[SerializeField] private float value;
	// Use this for initialization
	public float Value
	{
		get { return value; }
		set { this.value = value; }
	}
}

