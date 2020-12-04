using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/int")]
    public class IntVariable : MyScriptableObject
    {
        [SerializeField] readonly private int value;

        private int runtimeValue;
        public int Value { get { return value; } }

        public int RuntimeValue
        {
            get => runtimeValue;
            set => runtimeValue = value;
        }

        public void Modify(int val)
        {
            RuntimeValue += val;
        }
    }
}