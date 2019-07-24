using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// This is purely to keep track of whether or not a given tile already has a turret.
/// Could probably be made into a Scriptable object type
/// </summary>
public class TurretTileBehaviour : MonoBehaviour
{
	private bool _hasTurret;
}
