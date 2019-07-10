using UnityEngine;
using UnityEngine.Serialization;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu]
    public class Waypoint : MyScriptableObject
    {
        [FormerlySerializedAs("_point")] [SerializeField] private Vector3 point;

        public Waypoint(Transform tf)
        {
            point = tf.position;
        }
        
        public Vector3 Point { get { return point; } set { point = value; } }
    }
}