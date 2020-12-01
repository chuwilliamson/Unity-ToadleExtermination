using System.Collections;
using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using UnityEngine;

public class GameObjectContainer : MyScriptableObject
{
    //reference to a prefabbed game object, not meant to be changed
    [SerializeField] private readonly GameObject containedObject;

    //returns the object
    public GameObject ContainedObject => containedObject;
}
