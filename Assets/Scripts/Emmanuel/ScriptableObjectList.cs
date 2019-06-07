using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectList : ScriptableObject
{
    private List<ScriptableObject> _list;

    public List<ScriptableObject> List
    {
        get { return _list; }
        set { _list = value; }
    }
}
