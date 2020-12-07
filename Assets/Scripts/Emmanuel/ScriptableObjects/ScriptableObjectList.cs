using System.Collections;
using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using UnityEngine;

[CreateAssetMenu(menuName = "Lists/SriptableObjects List")]
public class ScriptableObjectList : MyScriptableObject
{

    //The list of scriptable objects
    [SerializeField] private List<MyScriptableObject> scriptableObjects;

    //Returns the the contents of scriptableObjects in the form of an array
    public MyScriptableObject[] ToArray()
    {
        return scriptableObjects.ToArray();
    }

    //Overloaded index operator, returns the corresponding index of scriptableObjects
    public object this[int index]
    {
        get {  return scriptableObjects[index];}
        set { scriptableObjects[index] = (MyScriptableObject)value;}
    }

    //Returns the lengths of scriptableObjects
    public int Count
    { 
        get{return scriptableObjects.Count;} 
    } 
}
