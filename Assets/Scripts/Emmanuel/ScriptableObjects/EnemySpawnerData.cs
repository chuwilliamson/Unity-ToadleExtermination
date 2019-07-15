using System.Collections.Generic;
using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Data/Enemy Spawner")]
    public class EnemySpawnerData : ScriptableObject
    {
        public List< GameObject > enemiesInThisWave;
        public int waveNumber;
    }
}