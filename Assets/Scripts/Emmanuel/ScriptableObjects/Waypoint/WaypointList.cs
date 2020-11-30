using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Emmanuel.ScriptableObjects;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Waypoint List")]
public class WaypointList : ScriptableObject
{
    public WaypointList(WaypointList wpList)
    {
        waypoints = new List< Waypoint >();
        foreach ( var waypoint in wpList.waypoints ) { waypoints.Add(waypoint); }
    }

    public WaypointList(Transform tf)
    {
        waypoints = new List< Waypoint >();
        waypoints.Add(new Waypoint(tf));
    }
    
    public List< Waypoint > waypoints;

    public void Add(Waypoint wp)
    {
        waypoints.Add(wp);
    }

    public void Add(Transform tf)
    {
        waypoints.Add(Waypoint.CreateInstance(tf));
    }

    public void Remove(Transform tf)
    {
        var wp = waypoints.Find(w => w.Point == tf.position);
        
        if ( wp == null )
            return;
        
        waypoints.Remove(wp);
    }

    public void Insert(int index, Transform tf)
    {
        waypoints.Insert(index, Waypoint.CreateInstance(tf));
    }
    
    
}