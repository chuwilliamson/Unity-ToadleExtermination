using UnityEngine;

namespace Emmanuel
{
    [CreateAssetMenu(menuName = "Variables/string")]
    public class stringVariable : MyScriptableObject
    {

        [SerializeField] private string value;

        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}