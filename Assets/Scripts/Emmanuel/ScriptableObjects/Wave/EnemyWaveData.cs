using System.Collections.Generic;
using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    /// <summary>
    /// This class is meant to:
    /// - be instantiated by the WaveController class
    /// - be made in the editor for pre-made waves
    /// </summary>
    [CreateAssetMenu(menuName = "Data/Enemy Wave")]
    public class EnemyWaveData : MyScriptableObject
    {
        //returns enemies in this wave
        public List< GameObject > enemiesInThisWave;

        /// <summary>
        /// Adds 
        /// </summary>
        /// <param name="waveEnemies"></param>
        public void Initialize(List<GameObject> waveEnemies)
        {
            enemiesInThisWave = waveEnemies;
        }
        
        //returns a random enemy in the wave
        public GameObject GetEnemy()
        {
            GameObject result;
            int enemyIndex = Random.Range(0, enemiesInThisWave.Count);
            result = enemiesInThisWave[enemyIndex];
            return result;
        }

        //returns the number of possible enemies in the wave
        public int EnemyCount { get { return enemiesInThisWave.Count; } }
    }
}