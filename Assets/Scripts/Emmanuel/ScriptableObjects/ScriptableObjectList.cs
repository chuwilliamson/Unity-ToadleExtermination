using System.Collections;
using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using UnityEngine;

[CreateAssetMenu(menuName = "Lists/SriptableObjects List")]
public class ScriptableObjectList : MyScriptableObject
{
    [SerializeField] private List<MyScriptableObject> scriptableObjects;

    public MyScriptableObject[] ToArray()
    {
        return scriptableObjects.ToArray();
    }
    public object this[int index]
    {
        get {  return scriptableObjects[index];}
        set { scriptableObjects[index] = (MyScriptableObject)value;}
    }
}
