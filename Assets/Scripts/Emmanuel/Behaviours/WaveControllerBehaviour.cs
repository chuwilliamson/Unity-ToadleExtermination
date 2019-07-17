using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Cinemachine;
using Emmanuel.ScriptableObjects;
using UnityEngine;

public class WaveControllerBehaviour : MonoBehaviour
{
	[SerializeField] private WaveController dualShock4;

	private EnemyWaveData currentWaveData;

	private int enemiesInThisWave;
	private int enemiesSpawnedSoFar;
	private float enemySpawnTimer;

	private string state;

	// Use this for initialization
	void Start()
	{
		dualShock4 = Instantiate(dualShock4);
		currentWaveData = Instantiate(dualShock4.GetNextWave);
		enemiesInThisWave = currentWaveData.EnemyCount;
		enemySpawnTimer = 0f;

		state = "Active";
	}

	// Update is called once per frame
	void Update()
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
		Debug.Log("State:: Sequence Commenced");
		state = "Active";
		currentWaveData = Instantiate(dualShock4.GetNextWave);
	}

	public void ConcludeSpawnSequence()
	{
		Debug.Log("State:: Sequence Concluded");
		state = "Inactive";
		enemiesSpawnedSoFar = 0;
	}

	void StatusCheck()
	{
		if (enemiesSpawnedSoFar > currentWaveData.EnemyCount)
			ConcludeSpawnSequence();
	}
	
}
