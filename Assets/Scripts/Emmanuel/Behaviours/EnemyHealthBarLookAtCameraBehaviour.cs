using UnityEngine;

namespace Emmanuel.Behaviours
{
    public class EnemyHealthBarLookAtCameraBehaviour : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            if ( Camera.main != null ) transform.LookAt(Camera.main.transform);
        }
    }
}