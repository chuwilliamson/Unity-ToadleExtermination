using System.Collections;
using System.Collections.Generic;
using Matthew;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class PhysicsTriggerListener : MonoBehaviour
{
    [Cinemachine.TagField]
    public string CompareTagField;

    public GameEvent TriggerEnterEvent;
    public GameEvent TriggerExitEvent;
    private void Start()
    {
        GetComponent<BoxCollider>().isTrigger = true;
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