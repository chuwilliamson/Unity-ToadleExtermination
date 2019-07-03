using UnityEngine;

namespace Matthew
{
    [RequireComponent(typeof(BoxCollider))]
    public class PhysicsTriggerHandler : MonoBehaviour
    {
        [Cinemachine.TagField]
        public string CompareTagField;

[SerializeField]
        private GameEvent TriggerEnterEvent;
        [SerializeField]
        private GameEvent TriggerExitEvent;
        private void Start()
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(CompareTagField))
            {
                TriggerEnterEvent.Raise(new[] { gameObject, other.gameObject });

            }

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(CompareTagField))
            {
                TriggerExitEvent.Raise(new[] { gameObject, other.gameObject });

            }
        }
    }
}