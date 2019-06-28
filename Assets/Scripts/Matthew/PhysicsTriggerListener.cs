﻿using UnityEngine;

namespace Matthew
{
    [RequireComponent(typeof(BoxCollider))]
    public class PhysicsTriggerListener : MonoBehaviour
    {
        [Cinemachine.TagField]
        public string CompareTagField;

        private GameEvent TriggerEnterEvent;
        private GameEvent TriggerExitEvent;
        private void Start()
        {
            GetComponent<BoxCollider>().isTrigger = true;
            TriggerEnterEvent = Resources.Load<GameEvent>("OnTriggerEnter");
            TriggerExitEvent = Resources.Load<GameEvent>("OnTriggerExit");
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(CompareTagField))
                TriggerEnterEvent.Raise(gameObject);
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(CompareTagField))
            {
                TriggerExitEvent.Raise(gameObject);
            }
        }
    }
}