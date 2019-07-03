using System;
using System.Collections;
using System.Collections.Generic;
using Matthew;
using Steffan.Behaviours;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

public class EnemyContactListBehaviour : MonoBehaviour
{
    public GameEvent OnEnemyAddedToContacts;
    //listen for the tongue hit 
    //when we add we raise an event that lets everyone know that a successful tongue hit happened
    //we raise that event with the object added and the listeners will check to see if "they" were the object
    //added
    // if they were the object added then they will care by taking damage
    public List< Object > objects = new List< Object >();

    public void AddToList(Object[] args)
    {
        var sender = args[0];
        var other = args[1];
        if (objects.Contains(other) ) //if we have it already
            RemoveFromList(other);//remove and readd it
        objects.Add(other);    //add it
        OnEnemyAddedToContacts.Raise(GetComponent<PlayerDataBehaviour>(), other);
    }

    public void RemoveFromList(Object obj)
    {
        if ( objects.Contains(obj) )
            objects.Remove(obj);
    }
}
