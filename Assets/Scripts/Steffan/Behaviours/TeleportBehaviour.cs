﻿using UnityEngine;

namespace Steffan.Behaviours
{
    /// <summary>
    /// This class handles teleportation of objects inside a scene.
    /// </summary>
    public class TeleportBehaviour : MonoBehaviour
    {
        [Header("This is the object that will be teleported to the destination.")]
        public Transform sourceObject;

        [Header("This is the target destination for the teleporting object.")]
        public Transform targetPosition;

        public void Teleport()
        {
            sourceObject.position = targetPosition.position;
        }

        public void Teleport(Vector3 target)
        {
            sourceObject.position = target;
        }
    }
}