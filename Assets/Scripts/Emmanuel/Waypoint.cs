using UnityEditorInternal;
using UnityEngine;

namespace Emmanuel
{
    public class Waypoint : ScriptableObject
    {
        private Vector3 _point;

        public Vector3 Point
        {
            get { return _point; }
            set { _point = value; }
        }
    }
}