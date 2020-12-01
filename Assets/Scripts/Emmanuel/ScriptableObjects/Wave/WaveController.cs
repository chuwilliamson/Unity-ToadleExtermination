using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using Matthew;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave Controller")]
public class WaveController : MyScriptableObject
{
    //total amount of waves until the game is won
    [SerializeField] private IntVariable totalWaves;
    
    //current amount of waves that have passed
    [SerializeField] private IntVariable wavesPassed;
    
    //the base time between each enemy spawning in a wave
    [SerializeField] private FloatVar enemySpawnFrequency;

    //countdown timer between the start of each waver
    [SerializeField] private FloatVar countdownTimer;

    //list of possible enemies for each wave
    [SerializeField] private ScriptableObjectList possibleEnemies;

    //index of possibleEnemies
    [SerializeField] private IntVariable possibleEnemiesIndex;

    //Game event that signals the end of the game by passing all the waves
    [SerializeField] private GameEvent gameWinEvent;

    public void Initialize()
    {
        //"resets" the index value 
        possibleEnemiesIndex.RuntimeValue = possibleEnemiesIndex.Value;
        
        //"resets the amount of waves that have passes
        wavesPassed.RuntimeValue = wavesPassed.Value;

        //"resets" the countdown timer
        countdownTimer.RuntimeValue = countdownTimer.Value;
        
        //"resets" the total amount of waves
        totalWaves.RuntimeValue = totalWaves.Value;

        //"resets" the enemy spawn frequency
        enemySpawnFrequency.RuntimeValue = enemySpawnFrequency.Value;
    }
    
    
    //Returns the EnemyWaveData that contains the enemies for the next wave
    public EnemyWaveData GetNextWave()
    {
        /*GetNextWave() gets called immediately after each wave, 
         so after completing the last wave the game should end*/
        if ((wavesPassed.RuntimeValue >= totalWaves.RuntimeValue))
        {
            gameWinEvent.Raise();
            return null;
        }

        //instantiate the list that enemy wave data will use to initialize
        List<GameObject> nextWaveEnemies = new List<GameObject>();

        //adds all possible enemies in possibleEnemies to possibleWaveEnemies
        for (int i = 0; i <= possibleEnemiesIndex.RuntimeValue; i++)
        {
            //casts the possible enemy as a game object container, the assignment should be done in the editor
            GameObjectContainer enemyContainer = possibleEnemies[i] as GameObjectContainer;
            
            //checks to see if the cast is null, if so then the problem is the reference from the editor
            if (enemyContainer != null) nextWaveEnemies.Add(enemyContainer.ContainedObject);
        }

        wavesPassed.RuntimeValue++;
        
        EnemyWaveData enemyWaveData = CreateInstance<EnemyWaveData>();
        enemyWaveData.Initialize(nextWaveEnemies);
        return enemyWaveData;
    }

    public float EnemySpawnFrequency => enemySpawnFrequency.RuntimeValue;
    public int TotalWaves => totalWaves.RuntimeValue;

}
