using System.Collections.Generic;
using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Data/Enemy Spawner")]
    public class EnemySpawnerData : ScriptableObject
    {
        public List< GameObject > enemiesInThisWave;
        public int waveNumber;

        public GameObject GetEnemy(int index = 0, bool random = false)
        {
            GameObject result;
            if ( random )
            {
                result = enemiesInThisWave[Random.Range(0, enemiesInThisWave.Count)];
            }
            var newindex = index > enemiesInThisWave.Count - 1 ? 0 : index;
            result = enemiesInThisWave[newindex];
            return result;
        }
    }
}