using System.Collections;
using System.Collections.Generic;
using Matthew;
using Steffan.Behaviours;
using UnityEngine;

public class GiveCurrencyOnDeathBehaviour : MonoBehaviour
{

	private EnemyDataBehaviour edBehaviour;

	public GameEvent onDeathEvent;
	
	// Use this for initialization
	void Start ()
	{
		edBehaviour = GetComponent< EnemyDataBehaviour >();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ( edBehaviour.ed.Health <= 0 )
		{
			RaiseOnDeathEvent();
			Destroy(gameObject);
		}
	}

	public void RaiseOnDeathEvent()
	{
		onDeathEvent.Raise(gameObject, edBehaviour);
	}
	
}
