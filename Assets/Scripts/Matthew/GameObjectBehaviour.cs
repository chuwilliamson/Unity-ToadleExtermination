using Chuwilliamson.Attributes;
using UnityEngine;

namespace Matthew
{
    //Raise events for all unity callback events
    public class GameObjectBehaviour : MonoBehaviour
    {
        [ScriptVariable(Verbose = true)] [SerializeField]
        private GameEvent _awakeEvent;

        [ScriptVariable(Verbose = true)] [SerializeField]
        private GameEvent _onDestroyEvent;

        [ScriptVariable(Verbose = true)] [SerializeField]
        private GameEvent _onDisableEvent;

        [ScriptVariable(Verbose = true)] [SerializeField]
        private GameEvent _onEnableEvent;

        [ScriptVariable(Verbose = true)] [SerializeField]
        private GameEvent _startEvent;

        [ScriptVariable(Verbose = true)] [SerializeField]
        private GameEvent _updateEvent;

        private void Awake()
        {
            _awakeEvent?.Raise(gameObject);
        }


        private void Start()
        {
            _startEvent?.Raise(gameObject);
        }

        private void OnEnable()
        {
            _onEnableEvent?.Raise(gameObject);
        }

        private void OnDisable()
        {
            _onDisableEvent?.Raise(gameObject);
        }


        private void Update()
        {
            _updateEvent?.Raise(gameObject);
        }

        private void OnDestroy()
        {
            _onDestroyEvent?.Raise(gameObject);
        }
    }
}