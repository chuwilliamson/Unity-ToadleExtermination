using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Global")]
public class Global : ScriptableObject {

    public void Print(string value)
    {
        Debug.Log(value);
    }
}
