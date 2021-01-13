using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/int")]
    public class IntVariable : MyScriptableObject
    {
        [SerializeField] private int value;

        [ReadOnly]
        public int RuntimeValue;
        public int Value { get { return value; } }

        public void Modify(int val)
        {
            RuntimeValue += val;
        }
    }
}