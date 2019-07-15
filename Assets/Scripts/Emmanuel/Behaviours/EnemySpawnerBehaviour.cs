using System.Collections.Generic;
using Emmanuel.ScriptableObjects;

using UnityEngine;

namespace Emmanuel.Behaviours
{
    public class EnemySpawnerBehaviour : MonoBehaviour
    {
        private int _enemyNumIndex;
        public List< GameObject > spawnedEnemies;
        [SerializeField] private EnemySpawnerData spawnerData;

        // Use this for initialization
        private void Start()
        {
            _enemyNumIndex = 0;
        }

        

        public void SpawnEnemy()
        {
            var spawnedEnemy = Instantiate(spawnerData.GetEnemy(random: randomEnemySelection), transform.position, Quaternion.identity);
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