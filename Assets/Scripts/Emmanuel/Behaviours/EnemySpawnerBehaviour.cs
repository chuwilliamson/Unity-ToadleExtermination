using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Matthew;
using Steffan.Behaviours;
using UnityEngine;

public class EnemySpawnerBehaviour : MonoBehaviour
{
	[SerializeField] private EnemySpawnerData spawnerData;

	private int enemyNumIndex;
	// Use this for initialization
	void Start ()
	{
		enemyNumIndex = 0;
	}

	public void SpawnEnemy()
	{
		var spawnedEnemy = Instantiate(spawnerData.enemiesInThisWave[enemyNumIndex] );
		enemyNumIndex++;
 
	}
}
