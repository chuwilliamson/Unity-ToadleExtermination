using Matthew;
using UnityEngine;
using UnityEngine.Serialization;

namespace Steffan.Behaviours
{
    public class TakeDamageWhenHitByTongueBehaviour : MonoBehaviour
    {
        public string damagerTag = "tongue";

        private EnemyDataBehaviour edBehaviour;

        [FormerlySerializedAs("OnTriggerEnterEvent")] public GameEvent onTriggerEnterEvent;

        public void Start()
        {
            edBehaviour = GetComponent<EnemyDataBehaviour>();
        }

        public void OnAddedToContactList(Object[] obj)
        {
            var sender = obj[0] as PlayerDataBehaviour; //sent from when the player adds this object to the contact list
            var defender = obj[1];
            if (sender == null) return;
            if (defender == null || defender != gameObject)
                return;
            sender.Attack(edBehaviour);
        }

        public void TakeTongueAttackDamage(Object[] obj)
        {
            var sender = obj[0] as PlayerDataBehaviour; //sent from when the player adds this object to the contact list
            var defender = obj[1];
            if (sender == null) return;
            if (defender == null || defender != gameObject)
                return;
            sender.Attack(edBehaviour);
        }
    }
}