using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Steffan.Behaviours;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class DieAfterAttackingPlayerBehaviour : MonoBehaviour
{
	private float damage;
	// Use this for initialization
	void Start ()
	{
		damage = GetComponent< EnemyDataBehaviour >().ed.Damage;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if ( other.gameObject.CompareTag("frog") )
		{
			var frogustus = other.gameObject.GetComponent< PlayerDataBehaviour >();

			frogustus.TakeDamage(damage);

			Debug.Log(frogustus.pd.Health);

			Destroy(gameObject);
		}
	}
}
