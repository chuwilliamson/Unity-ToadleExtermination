using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/int")]
    public class IntVariable : MyScriptableObject
    {
        [SerializeField] private int value;

        public int Value { get { return value; } set { this.value = value; } }

        public void Modify(int val)
        {
            Value += val;
        }
    }
}