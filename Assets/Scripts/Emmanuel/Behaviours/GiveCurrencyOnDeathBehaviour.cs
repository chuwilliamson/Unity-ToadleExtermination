using Matthew;
using Steffan.Behaviours;
using UnityEngine;

namespace Emmanuel.Behaviours
{
    public class GiveCurrencyOnDeathBehaviour : MonoBehaviour
    {
        private EnemyDataBehaviour _edBehaviour;

        public GameEvent onDeathEvent;

        // Use this for initialization
        private void Start()
        {
            _edBehaviour = GetComponent< EnemyDataBehaviour >();
        }

        // Update is called once per frame
        private void Update()
        {
            if ( _edBehaviour.ed.Health <= 0 )
            {
                onDeathEvent.Raise(gameObject, _edBehaviour.ed);
                Destroy(gameObject);  
            }
        }
    }
}