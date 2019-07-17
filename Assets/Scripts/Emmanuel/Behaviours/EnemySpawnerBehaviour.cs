using System.Collections.Generic;
using Emmanuel.ScriptableObjects;

using UnityEngine;
using UnityEngine.Serialization;

namespace Emmanuel.Behaviours
{
    public class EnemySpawnerBehaviour : MonoBehaviour
    {
        private int _enemyNumIndex;
        public List< GameObject > spawnedEnemies;
        [FormerlySerializedAs("spawnerData")] [SerializeField] private EnemyWaveData waveData;

        private WaveController waveController;

        // Use this for initialization
        private void Start()
        {
            _enemyNumIndex = 0;

            waveController = Resources.Load< WaveController >("Emmanuel/ScriptableObjects");
        }

        public void SpawnEnemy()
        {
            var spawnedEnemy = Instantiate(waveData.GetEnemy(random: randomEnemySelection), transform.position, Quaternion.identity);
            spawnedEnemies.Add(spawnedEnemy);
        }

        private bool randomEnemySelection = true;
        public int deathcount = 0;
        public void OnEnemyDied(Object[] objects)
        {
            var sender = objects[0];
            if ( spawnedEnemies.Contains(sender as GameObject) )
            {
                Destroy(sender as GameObject);
                deathcount++;
            }
        }
    }
}