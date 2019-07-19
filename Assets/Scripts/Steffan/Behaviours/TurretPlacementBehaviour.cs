using System.Collections.Generic;
using Emmanuel.Interfaces;
using Emmanuel.ScriptableObjects;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

namespace Steffan.Behaviours
{
    public class TurretPlacementBehaviour : MonoBehaviour
    {
        public List<GameObject> placedObjects;

        private IWheelObject w;
        [SerializeField] private int turretCost;
        [SerializeField] private PlayerData pd;

        // Use this for initialization
        private void Start()
        {
            w = new TurretWheelObject();
            pd = Resources.Load("Emmanuel/PlayerDatas/FrogustusPlayerData") as PlayerData;
        }

        public bool BuyTurret()
        {
            if (pd.Currency > turretCost
        }

        public void PlaceTurret()
        {
            if (!WaveState.IsBuildPhase)
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
        }

        private void Update()
        {
            if (Input.mouseScrollDelta.y > 0)
                w.Up();
            if (Input.mouseScrollDelta.y < 0)
                w.Down();
        }

        public class TurretWheelObject : IWheelObject
        {

            [SerializeField] private int currentIndex;

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

            public class TestWheelObject : IWheelObject
            {
                [SerializeField] private int currentIndex;

                private readonly List<GameObject> Turrets;

                public TestWheelObject()
                {

                    Turrets = new List<GameObject>();
                    var results = Resources.LoadAll("Prefabs/TestTurrets", typeof(GameObject));
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
            }
        }
    }
}