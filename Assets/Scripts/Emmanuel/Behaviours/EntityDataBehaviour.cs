using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using Emmanuel.ScriptableObjects;
using UnityEngine;

public class EntityDataBehaviour : MonoBehaviour
{

	public Entity entityData;
	// Use this for initialization
	void Start ()
	{
		entityData = Instantiate(entityData);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	virtual public void Attack(EntityDataBehaviour other)
	{
		throw new System.NotImplementedException();
	}

	virtual public float TakeDamage(float dmgTaken)
	{
		throw new System.NotImplementedException();
	}
}
