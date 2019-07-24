﻿using Emmanuel.ScriptableObjects;
using Steffan.Behaviours;
using UnityEngine;

public class WaveControllerBehaviour : MonoBehaviour
{
	//Changed to continuous wave
	[SerializeField] private WaveController dualShock4;

	private EnemyWaveData currentWaveData;

	[SerializeField] private WaypointList wpList;

	private GameObject enemyType;
	private GameObject enemyType2;

	private float enemyType2Timer;

	private float enemySpawnTimer;
	

	private int numberOfEnemiesToSpawn;
	
	private int enemiesInThisWave;
	private int enemiesSpawnedSoFar;
	
	private string state;

	// Use this for initialization
	void Start()
	{
		dualShock4 = Instantiate(dualShock4);
		currentWaveData = Instantiate(dualShock4.GetNextWave);
		
		enemySpawnTimer = 0f;
		numberOfEnemiesToSpawn = 0;

		enemyType2Timer = 0;

		enemyType = currentWaveData.GetEnemy();
		enemyType2 = currentWaveData.GetEnemy();


		//state = "Active";
		//enemiesInThisWave = currentWaveData.EnemyCount;
	}

	// Update is called once per frame
	void Update()
	{
		enemySpawnTimer += Time.deltaTime;
		if ( enemySpawnTimer >= dualShock4.EnemySpawnFrequency )
		{
			enemySpawnTimer = 0;
			var enemy = Instantiate(enemyType);
			enemy.transform.position = transform.position;

			var pathToFollow = enemy.GetComponent< FollowPathBehaviour >();
			pathToFollow.waypointsToFollow = new WaypointList(wpList);

			enemyType2Timer += 1;
		}

		if ( enemyType2Timer >= 10 )
		{
			enemyType2Timer = 0;

			var enemy = Instantiate(enemyType);
			enemy.transform.position = transform.position;

			var pathToFollow = enemy.GetComponent< FollowPathBehaviour >();
			pathToFollow.waypointsToFollow = new WaypointList(wpList);
		}
	}

	private void OldUpdate()
	{
		StatusCheck();
		
		switch ( state )
		{
			case "Active":
			{
				enemySpawnTimer += Time.deltaTime;
				if ( enemySpawnTimer >= dualShock4.EnemySpawnFrequency )
				{
					enemySpawnTimer = 0;
					var enemy = Instantiate(currentWaveData.GetEnemy());
					enemy.transform.position = transform.position;

					var pathToFollow = enemy.GetComponent< FollowPathBehaviour >();
					pathToFollow.waypointsToFollow = new WaypointList(wpList);

					enemiesSpawnedSoFar += 1;
				}
				break;
			}

			case "Inactive":
			{
				enemySpawnTimer = 0;
				break;
			}
		}
		
		
	}

	public void NextWave()
	{
		currentWaveData = Instantiate(dualShock4.GetNextWave);
	}

	public void CommenceSpawnSequence()
	{
		state = "Active";
		NextWave();
	}

	public void ConcludeSpawnSequence()
	{
		state = "Inactive";
		enemiesSpawnedSoFar = 0;
	}

	void StatusCheck()
	{
		if (enemiesSpawnedSoFar > currentWaveData.EnemyCount)
			ConcludeSpawnSequence();
	}
	
}
