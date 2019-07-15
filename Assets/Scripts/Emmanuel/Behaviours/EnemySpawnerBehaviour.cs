using Emmanuel.ScriptableObjects;
using UnityEngine;

namespace Emmanuel.Behaviours
{
    public class EnemySpawnerBehaviour : MonoBehaviour
    {
        private int _enemyNumIndex;

        [SerializeField] private EnemySpawnerData spawnerData;

        // Use this for initialization
        private void Start()
        {
            _enemyNumIndex = 0;
        }

        public void SpawnEnemy()
        {
            var spawnedEnemy = Instantiate(spawnerData.enemiesInThisWave[_enemyNumIndex]);
            spawnedEnemy.gameObject.transform.position = transform.position;
            _enemyNumIndex++;
        }
    }
}