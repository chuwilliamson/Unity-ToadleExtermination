using UnityEditorInternal;
using UnityEngine;

namespace Emmanuel
{
    [CreateAssetMenu]
    public class Waypoint : MyScriptableObject
    {
        private Vector3 _point;

        public Vector3 Point
        {
            get { return _point; }
            set { _point = value; }
        }
    }
}