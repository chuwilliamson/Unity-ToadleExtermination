using System;
using System.Collections;
using System.Collections.Generic;
using Emmanuel;
using Steffan;
using UnityEngine;

public class TakeDamageWhenHitByTongueBehaviour : MonoBehaviour
{
	public string damagerTag = "tongue";
	public EnemyDataBehaviour ed;
	private void Start()
	{
		ed = GetComponent<EnemyDataBehaviour>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!other.gameObject.CompareTag(damagerTag))
			return;

		var damager = other.gameObject.GetComponent<PlayerDataBehaviour>();
		// damager.Attack();
		// TODO: This gameobject takes damage when the Tongue enters its collider
	}
}
