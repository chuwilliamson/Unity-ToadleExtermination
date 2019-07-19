using Chuwilliamson.Attributes;
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

        public void OnEnable()
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
                   
        public void OnEventRaised(Object[] args)
        {
            var sender = args[0];
            var other = args[1];
            //if it's null we will call it
            if (SenderObject == null)
            {
                Response.Invoke(args);
            }
            else
            {
                if (SenderObject == args[0])
                    Response.Invoke(args);
            }
        }


        public void OnDisable()
        {
            Unsubscribe();
        }

        public void OnEventRaised()
        {
            OnEventRaised(null);
        }
    }
}