using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/string")]
    public class StringVariable : MyScriptableObject
    {
        [SerializeField] private string value;

        public string Value { get { return value; } set { this.value = value; } }
    }
}