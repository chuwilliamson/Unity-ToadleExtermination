using UnityEngine;

namespace Steffan.Behaviours
{
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

        public void Teleport(Transform target)
        {
            sourceObject = target;
        }
    }
}