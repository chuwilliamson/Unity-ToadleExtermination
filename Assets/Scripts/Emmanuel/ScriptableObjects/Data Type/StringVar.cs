using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/string")]
    public class StringVariable : MyScriptableObject
    {
        [SerializeField] private readonly string value;

        [ReadOnly]
        public string RuntimeValue;

        public string Value
        {
            get { return value; }
        }
    }
}