using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Steffan;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Global")]
public class Global : ScriptableObject
{
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index, LoadSceneMode.Additive);
    }
    public void Print(string value)
    {
        Debug.Log(value);
    }

    public void PrintState(string value)
    {
        Debug.Log(WaveState.IsBuildPhase.ToString());
    }
}
