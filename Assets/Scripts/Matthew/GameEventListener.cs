﻿using Chuwilliamson.Attributes;
using UnityEngine;

namespace Matthew
{
    public class GameEventListener : MonoBehaviour, IListener
    {
        [TextArea]
        public string Notes;
        [ScriptVariable(Verbose = true)]
        public GameEvent GameEvent;
        public GameEventResponse Response;
        
        public GameObject SenderObject;
        
        void OnEnable()
        {
            Subscribe();
        }
        public void Subscribe()
        {
            GameEvent.AddListener(this);
        }

        public void Unsubscribe()
        {
            GameEvent.RemoveListener(this);
        }

    public void OnEventRaised(Object obj)
            {
                //if it's null we will call it
                if (SenderObject == null)
                {
                    Response.Invoke(obj);
    
                }
                else
                {
                    if (SenderObject == obj)
                        Response.Invoke(obj);
                }
            }

        public void OnEventRaised()
        {
            OnEventRaised(null);
        }

        void OnDisable()
        {
            Unsubscribe();
        }
    }
}