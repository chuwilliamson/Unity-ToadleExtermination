using System.Collections;
using System.Collections.Generic;
using Matthew;
using Steffan.Behaviours;
using UnityEngine;

public class EmemyDeathBehaviour : MonoBehaviour
{
	private EnemyDataBehaviour edBehaviour;
	public GameEvent OnEnemyDeath;
	private Animator animator;
	private bool hasStartedDying;
	private bool dyingAnimationStarted;

	// Use this for initialization
	void Start ()
	{
		edBehaviour = GetComponent< EnemyDataBehaviour >();
		animator = GetComponent< Animator >();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ( edBehaviour.ed.health.Value <= 0 && !hasStartedDying ) { hasStartedDying = true; }
		if ( hasStartedDying )
		{
			//ToDo:: EnemyDeathAnimation for when there is time
			//dyingAnimationStarted = true;
			//animator.SetTrigger("death");
			
			DestroyMe();
		}
	}

	public void DestroyMe()
	{
		Destroy(gameObject);
	}
	
}
