using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/float")]
    public class FloatVar : MyScriptableObject
    {
        [SerializeField] private float value;

        private float runtimeValue;

        // Use this for initialization
        public float Value { get { return value; } set { this.value = value; } }

        public float RuntimeValue
        {
            get => runtimeValue;
            set => runtimeValue = value;
        }
    }
}