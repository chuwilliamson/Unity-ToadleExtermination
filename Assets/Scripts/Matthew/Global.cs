using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
[CreateAssetMenu(menuName = "Global")]
public class Global : ScriptableObject
{
    public void Print(string value)
    {
        Debug.Log(value);
    }
    
    public void PrintState(string value)
    {
        Debug.Log(WaveStateStatic.IsWavePhase.ToString());
    }
}
