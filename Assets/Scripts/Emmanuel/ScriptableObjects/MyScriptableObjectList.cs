using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Lists/Scriptable Object List")]
    public class ScriptableObjectList : MyScriptableObject, IList< MyScriptableObject >
    {
        public List< ScriptableObject > List { get; set; }

        public IEnumerator< MyScriptableObject > GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(MyScriptableObject item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(MyScriptableObject item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(MyScriptableObject[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(MyScriptableObject item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; private set; }

        public bool IsReadOnly { get; private set; }

        public int IndexOf(MyScriptableObject item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, MyScriptableObject item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public MyScriptableObject this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}