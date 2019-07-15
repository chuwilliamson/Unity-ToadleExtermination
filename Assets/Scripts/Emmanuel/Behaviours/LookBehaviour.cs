using UnityEngine;

//ToDo:: IDK HOW TF THIS WORKS IF IT DO
namespace Emmanuel.Behaviours
{
    public class LookBehaviour : MonoBehaviour
    {
        private Vector3 _mousePositionInWorld;

        private Vector3 _targetPos;

        public bool movePrefab;

        public GameObject prefab;

        private void Awake()
        {
            if ( prefab )
                prefab.layer = 2;
            else
                Debug.Log("No Prefab Assigned");
        }

        // Update is called once per frame
        private void Update()
        {
            if ( Camera.main == null ) return;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayCastHit;
            if ( !Physics.Raycast(ray, out rayCastHit, Mathf.Infinity) ) return;
            _mousePositionInWorld = rayCastHit.point;
            CalculateTargetPosition(rayCastHit.point);
            if ( movePrefab && prefab )
                prefab.transform.position = _targetPos;
        }

        private void CalculateTargetPosition(Vector3 hit)
        {
            if ( Camera.main == null ) return;
            var mouseScreenToWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var yTotal = hit.y - mouseScreenToWorld.y;
            var newY = yTotal - (hit.y - transform.position.y);

            var factor = newY / yTotal;
            _targetPos = mouseScreenToWorld + (hit - mouseScreenToWorld) * factor;
        }
    }
}