using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnSpawnerBehaviour : MonoBehaviour
{
	public int SpawnerSpawnInterval;
	private float spawnerSpawnerTimer;
	[SerializeField] private GameObject spawnerPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		spawnerSpawnerTimer += Time.deltaTime;
		if ( spawnerSpawnerTimer >= SpawnerSpawnInterval )
		{
			spawnerSpawnerTimer = 0;
			var spawner = Instantiate(spawnerPrefab);
			spawner.transform.position += Random.insideUnitSphere;
		}
	}
}
