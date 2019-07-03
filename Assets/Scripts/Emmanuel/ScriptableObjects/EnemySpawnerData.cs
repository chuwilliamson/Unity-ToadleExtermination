using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Enemy Spawner")]
public class EnemySpawnerData : ScriptableObject
{
	public int waveNumber;
	public List< GameObject > enemiesInThisWave;
}
