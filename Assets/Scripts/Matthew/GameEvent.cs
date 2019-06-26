﻿using System.Collections.Generic;
using UnityEngine;

namespace Matthew
{
    [CreateAssetMenu(menuName = "GameEvents/GameEvent")]
    public class GameEvent : ScriptableObject, ISubscribeable
    {
        private List<IListener> listeners = new List<IListener>();

        public void Raise(Object obj)
        {
            for (var i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(obj);
        }
        public void Raise()
        {
            Raise(null);
        }
        public void AddListener(IListener listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(IListener listener)
        {
            listeners.Remove(listener);
        }
    }
}