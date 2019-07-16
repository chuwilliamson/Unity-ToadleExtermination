using System;
using System.Collections;
using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave Controller")]
public class WaveController : ScriptableObject
{
    [SerializeField] private int totalWaves;
    [SerializeField] float enemySpawnFrequency;

    public float Timer { get; set; }

    private int currentWave;

    [SerializeField] private List< EnemyWaveData > listOfWaves;

    public void InitializeAllWaves()
    {
        if (listOfWaves == null)
            listOfWaves = new List< EnemyWaveData >();
        
        //TODO:: Load each list of waves from the resources folder
    }
    
    

    public EnemyWaveData GetNextWave
    {
        get
        {
            if ( (currentWave > totalWaves) ) return listOfWaves[totalWaves - 1];
            
            return listOfWaves[currentWave++];
        }
    }
    
    public float EnemySpawnFrequency { get { return enemySpawnFrequency; } }
    public int TotalWaves { get { return totalWaves; } }
    
}
