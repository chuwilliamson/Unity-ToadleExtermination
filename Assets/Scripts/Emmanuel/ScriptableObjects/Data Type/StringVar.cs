using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/string")]
    public class StringVariable : MyScriptableObject
    {
        [SerializeField] private readonly string value;

        private string runtimeValue;

        public string Value
        {
            get { return value; }
        }

        public string RuntimeValue
        {
            get => runtimeValue;
            set => runtimeValue = value;
        }
    }
}