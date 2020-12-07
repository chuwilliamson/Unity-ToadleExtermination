using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using UnityEngine;
using UnityEngine.Serialization;

namespace Emmanuel.Behaviours
{
    public class EnemySpawnerBehaviour : MonoBehaviour
    {
        //the amount of enemies that will spawn in each wave
        public int EnemiesEachWave;

        //how often an enemy will spawn during the wave
        private float enemySpawnFrequency;

        //WaveController, drag in from asset folder, provides all the data to spawn enemies
        public WaveController WaveController;

        //Possible enemies in a wave
        private EnemyWaveData enemyWaveData;


        void Update()
        {

        }
    }
}