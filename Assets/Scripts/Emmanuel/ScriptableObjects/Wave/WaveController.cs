using System;
using System.Collections;
using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave Controller")]
public class WaveController : ScriptableObject
{
    [SerializeField] private int totalWaves;
    [SerializeField] private float enemySpawnFrequency;

    public float Timer { get; set; }

    private int currentWave;

    [SerializeField] private List< EnemyWaveData > listOfWaves;

    public void Initialize()
    {
        if (listOfWaves == null)
            listOfWaves = new List< EnemyWaveData >();

        totalWaves = listOfWaves.Count;
    }
    
    
    public EnemyWaveData GetNextWave
    {
        get
        {
            currentWave++;
            
            if ( (currentWave >= totalWaves) ) return listOfWaves[0];

            return listOfWaves[currentWave];
        }
    }
    
    public float EnemySpawnFrequency { get { return enemySpawnFrequency; } }
    public int TotalWaves { get { return totalWaves; } }
    
}
