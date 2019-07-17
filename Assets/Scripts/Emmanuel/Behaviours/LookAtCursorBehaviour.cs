using UnityEngine;

namespace Emmanuel.Behaviours
{
    public class LookAtCursorBehaviour : MonoBehaviour
    {
        [SerializeField] private GameObject cursor;

        // Update is called once per frame
        private void Update()
        {
            RotateTowards(cursor.transform.position);
        }

        private void RotateTowards(Vector3 to)
        {
            var lookRotation = Quaternion.LookRotation((to - transform.position).normalized);

            transform.rotation = lookRotation;
        }
    }
}