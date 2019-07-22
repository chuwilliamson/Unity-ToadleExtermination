using System.Collections.Generic;
using Emmanuel.Interfaces;
using Emmanuel.ScriptableObjects;
using Matthew;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

namespace Steffan.Behaviours
{
    public class TurretPlacementBehaviour : MonoBehaviour
    {
        public List<GameObject> placedObjects;
        public GameEvent OnTurretSummon;
        private IWheelObject w;
        public IWheelObject W => w;

        public IntVariable PlayerCurrency;
        [SerializeField] private int startingCurrency;
        [SerializeField] private int TurretCost;
        public IntVariable CurrentTurretIndex;

        // Use this for initialization
        private void Start()
        {
            // For testing
            w = new TurretWheelObject();

            PlayerCurrency.Value = startingCurrency;
        }

        public void PlaceTurret()
        {
            if (PlayerCurrency.Value < TurretCost)
                return;
            
            if (EventSystem.current.currentSelectedGameObject == null)
                return;
            
            var tileClicked = EventSystem.current.currentSelectedGameObject;
            var tileBehaviour = tileClicked.GetComponent<TileBehaviour>();

            if (tileBehaviour.HasTurret)
                return;
            
            var pos = tileClicked.transform.position;
            
            placedObjects.Add(Instantiate(w.Current, pos, Quaternion.identity) as GameObject);
            tileBehaviour.HasTurret = true;
            PlayerCurrency.Modify(-TurretCost);
            OnTurretSummon.Raise();
        }

        private void Update()
        {
            if (Input.mouseScrollDelta.y > 0)
                w.Up();
            if (Input.mouseScrollDelta.y < 0)
                w.Down();
            CurrentTurretIndex.Value = w.Index;
        }

        public class TurretWheelObject : IWheelObject
        {

            private int currentIndex;

            public int ReturnCurrentIndex()
            {
                return currentIndex;
            }

            private readonly List<GameObject> Turrets;

            public TurretWheelObject()
            {

                Turrets = new List<GameObject>();
                var results = Resources.LoadAll("Prefabs/TurretList", typeof(GameObject));
                //casting a collection as another collection does not work..
                foreach (var res in results) Turrets.Add(res as GameObject);
            }

            public void Up()
            {
                var newindex = currentIndex + 1;
                currentIndex = newindex > Turrets.Count - 1 ? 0 : newindex;
                Debug.Log(currentIndex);
            }

            public void Down()
            {
                var newindex = currentIndex - 1;
                currentIndex = newindex < 0 ? Turrets.Count - 1 : newindex;
                Debug.Log(currentIndex);
            }

            public Object Current
            {
                get { return Turrets[currentIndex]; }
            }

            public int Index
            {
                get { return currentIndex; }
            }
        }
    }
}