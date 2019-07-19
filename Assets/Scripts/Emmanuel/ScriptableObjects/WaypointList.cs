using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
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
        waypoints.Add(new Waypoint(tf));
    }

    public void Remove(Transform tf)
    {
        int indexToRemove = 0;
        foreach ( var waypoint in waypoints )
        {
            if ( waypoint.Point == tf.position )
            {
                break;
            }
            indexToRemove++;
        }

        if ( waypoints[indexToRemove] == null ) { return; }
        waypoints.RemoveAt(indexToRemove);
    }

    public void Insert(int index, Transform tf)
    {
        waypoints.Insert(index, new Waypoint(tf));
    }
    
    
}