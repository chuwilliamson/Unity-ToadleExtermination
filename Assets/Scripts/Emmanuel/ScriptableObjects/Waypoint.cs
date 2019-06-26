using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu]
    public class Waypoint : MyScriptableObject
    {
        [SerializeField] private Vector3 _point;

        public Vector3 Point
        {
            get { return _point; }
            set { _point = value; }
        }
    }
}