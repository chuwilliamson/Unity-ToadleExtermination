using System;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

namespace Steffan.Behaviours
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]
    public class FollowPathBehaviour : MonoBehaviour
    {
        public enum MoveMethod
        {
            Idle,
            Travel
        }

        [TagField] private string _cmTagField;

        public bool loop;

        public MoveMethod movement;

        public NavMeshAgent navmeshAgent;

        [FormerlySerializedAs("SavedPath")] public WaypointList savedPath;

        [SerializeField] private float speed = 5f;

        [FormerlySerializedAs("Teleporter")]
        [Header("This is the teleport controller. " +
                "Recommend creating a Teleporter game object with the TeleportBehaviour script")]
        public TeleportBehaviour teleporter;

        [FormerlySerializedAs("WaypointsPassed")] [Header("This is a list of gameobjects(Waypoints) that has been passed by the object.")]
        public WaypointList waypointsPassed;

        [FormerlySerializedAs("WaypointsToFollow")]
        [Space(10)]
        [Header("[Readme] This causes the object to follow the given path of waypoints.")]
        [Space(10)]
        [Header("Assign gameobjects(Waypoints) to the list to have the object approach them in that order.")]
        public WaypointList waypointsToFollow;

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private void Start()
        {
            movement = MoveMethod.Travel;
            savedPath = new WaypointList(waypointsToFollow);
            navmeshAgent = GetComponent<NavMeshAgent>();
        }

        private void RestartPath()
        {
            waypointsToFollow = new WaypointList(savedPath);
            transform.position = waypointsToFollow.waypoints[0].Point;
        }

        // Update is called once per frame
        private void Update()
        {
            if (waypointsToFollow.waypoints.Count < 1)
            {
                if (loop) RestartPath();

                return;
            }

            switch (movement)
            {
                case MoveMethod.Travel:
                    WaypointTravel();
                    break;
                case MoveMethod.Idle:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.CompareTag("Waypoint"))
                return;
            if (waypointsToFollow.waypoints.Count < 1) return;

            waypointsToFollow.Remove(other.gameObject.transform);
        }

        private void WaypointTravel()
        {
            if (waypointsToFollow.waypoints.Count == 0)
                return;
            navmeshAgent.SetDestination(waypointsToFollow.waypoints[0].Point);
        }

        public void NextWaypointTeleport()
        {
            teleporter.Teleport(waypointsToFollow.waypoints[0].Point);
        }

        public void ChangeMoveMethod(int val)
        {
            movement = (MoveMethod) val;
        }
    }
}