using System.Collections;
using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using UnityEngine;

[CreateAssetMenu(menuName = "Containers/GameObject Containers")]
public class GameObjectContainer : MyScriptableObject
{
    //reference to a prefabbed/serialized game object, not meant to be changed
    [SerializeField] private GameObject containedObject;

    //returns the object
    public GameObject ContainedObject => containedObject;
}
