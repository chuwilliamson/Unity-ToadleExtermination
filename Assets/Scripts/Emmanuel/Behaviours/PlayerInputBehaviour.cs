using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class PlayerInputBehaviour : MonoBehaviour
{
    [FormerlySerializedAs("OnLeftMouseButtonDown")] [SerializeField] private UnityEvent onLeftMouseButtonDown;
    [SerializeField] private UnityEvent onMouseRightButtonDown;
    [SerializeField] private UnityEvent onMouseScrollUp;
    [SerializeField] private UnityEvent onMouseScrollDown;
    [SerializeField] private UnityEvent onSpacePressed;
    

    private float previousMouseScrollValue;

    private void Start()
    {
        previousMouseScrollValue = Input.mouseScrollDelta.y;
    }
    
    // Update is called once per frame
    private void Update()
    {
        if ( Input.GetMouseButtonDown(0) ) onLeftMouseButtonDown.Invoke();
        if (Input.GetMouseButtonDown(1) ) onMouseRightButtonDown.Invoke();

        if ( Input.mouseScrollDelta.y > previousMouseScrollValue )
        {
            onMouseScrollUp.Invoke();
            previousMouseScrollValue = Input.mouseScrollDelta.y;
        }

        if ( Input.mouseScrollDelta.y < previousMouseScrollValue )
        {
            onMouseScrollDown.Invoke();
            previousMouseScrollValue = Input.mouseScrollDelta.y;
        }
        

    }
}