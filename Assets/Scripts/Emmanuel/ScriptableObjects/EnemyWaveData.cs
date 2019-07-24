using System.Collections.Generic;
using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Data/Enemy Spawner")]
    public class EnemyWaveData : ScriptableObject
    {
        public List< GameObject > enemiesInThisWave;
        private int enemyIndex = 0;

        public GameObject GetEnemy(int index = 0, bool random = false)
        {
            if ( enemyIndex == 0 ) enemyIndex++;
            /*
            GameObject result;
            if ( random )
            {
                result = enemiesInThisWave[Random.Range(0, enemiesInThisWave.Count)];
            }
            var newindex = index > enemiesInThisWave.Count - 1 ? 0 : index;
            result = enemiesInThisWave[newindex];
            return result;
            */

            return enemiesInThisWave[enemyIndex];
        }

        public int EnemyCount { get { return enemiesInThisWave.Count; } }

    }
}