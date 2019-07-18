using System;
using Emmanuel.ScriptableObjects;
using Matthew;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Steffan.Behaviours
{
    public class EnemyDataBehaviour : MonoBehaviour
    {
        bool isDead;
        GameEvent onDeathEvent;
        public EnemyData ed;

        public int Value { get { return ed.value; } }

        // Use this for initialization
        private void Awake()
        {
            ed = Instantiate(ed);
            ed.health = Instantiate(ed.health);
            ed.damage = Instantiate(ed.damage);
        }

        private void Start()
        {
            onDeathEvent = Resources.Load<GameEvent>("OnEnemyDeath");
        }

        public void Attack(PlayerDataBehaviour other)
        {
            other.TakeDamage(ed.Damage);
        }

        public void TakeDamage(PlayerData playerData)
        {
            TakeDamage(playerData.Damage);
        }

        public void OnAddedToContactList(Object[] obj)
        {
            var sender = obj[0] as PlayerDataBehaviour; //sent from when the player adds this object to the contact list
            var defender = obj[1];
            if ( sender == null ) return;
            if ( defender == null || defender != gameObject )
                return;
            sender.Attack(this);
        }

        public void onTriggerEnterEventRaised(Object other)
        {
            var damager = ((GameObject) other).gameObject.GetComponent< PlayerDataBehaviour >();
            if ( damager == null )
                return;
            Debug.Log(damager.pd.Damage.ToString());
            damager.Attack(this);
        }

        public void TakeDamage(float dmgTaken)
        {
            if ( isDead )
                return;
            var newhealth = ed.TakeDamage(dmgTaken);
            if ( newhealth <= 0 )
            {
                onDeathEvent.Raise(gameObject, this);
                isDead = true;
            }
        }
    }

    #if UNITY_EDITOR
    [CustomEditor(typeof(EnemyDataBehaviour))]
    public class TestEnemyDataBehaviourInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            var mt = target as EnemyDataBehaviour;
            if ( GUILayout.Button("die") )
            {
                mt.TakeDamage(0);
            }
        }
    }
    #endif
}