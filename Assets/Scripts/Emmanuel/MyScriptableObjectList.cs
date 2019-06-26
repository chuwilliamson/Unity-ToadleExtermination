using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Emmanuel
{
    [CreateAssetMenu]
    public class ScriptableObjectList : ScriptableObject, IList<MyScriptableObject>
    {
        private List<ScriptableObject> _list;

        public List<ScriptableObject> List
        {
            get { return _list; }
            set { _list = value; }
        }

        public IEnumerator<MyScriptableObject> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(MyScriptableObject item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(MyScriptableObject item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(MyScriptableObject[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(MyScriptableObject item)
        {
            throw new System.NotImplementedException();
        }

        public int Count { get; private set; }
        
        public bool IsReadOnly { get; private set; }
        
        public int IndexOf(MyScriptableObject item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, MyScriptableObject item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public MyScriptableObject this[int index]
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}
