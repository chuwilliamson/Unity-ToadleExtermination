using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class PlayerInputBehaviour : MonoBehaviour
{
    // Use this for initialization
    [FormerlySerializedAs("OnLeftMouseButtonDown")] [SerializeField] private UnityEvent onLeftMouseButtonDown;

    // Update is called once per frame
    private void Update()
    {
        if ( Input.GetMouseButtonDown(0) ) onLeftMouseButtonDown.Invoke();
    }
}