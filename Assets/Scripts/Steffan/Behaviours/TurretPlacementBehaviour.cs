using System.Collections.Generic;
using Emmanuel.Interfaces;
using Emmanuel.ScriptableObjects;
using Matthew;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

namespace Steffan.Behaviours
{
    /// <summary>
    /// This is the meat of what makes turrets placeable.
    /// It has reference to the player's current amount of currency via a Scriptable Object.
    /// It has a turret cost value.
    /// It also has an implementation of the IWheelObject interface, so as to control the current turret using the
    /// scroll wheel.
    /// Give this to a single Handler object in the scene.
    /// </summary>
    public class TurretPlacementBehaviour : MonoBehaviour
    {
        /// <summary>
        /// List of all placed objects through this Behaviour.
        /// </summary>
        public List<GameObject> placedObjects;
        
        /// <summary>
        /// Raise an Event on summoning a turret
        /// </summary>
        public GameEvent OnTurretSummon;
        
        /// <summary>
        /// Implementation of an interface to allow for selecting a turret.
        /// </summary>
        private IWheelObject w; 
       
        /// <summary>
        /// Reference to SO containing Player Currency
        /// </summary>
        public IntVariable PlayerCurrency;
        
        /// <summary>
        /// The amount of currency that is assigned to the player at the start of the game
        /// </summary>
        [SerializeField] private int startingCurrency;
        
        /// <summary>
        /// How much currency a turret costs to place
        /// </summary>
        [SerializeField] private int TurretCost;
        
        /// <summary>
        /// Reference to the index of the currently selected turret through the IWheelObject
        /// </summary>
        public IntVariable CurrentTurretIndex;
        
        /// <summary>
        /// Instantiates the IWheelObject and sets the PlayerCurrency SO to the startingCurrency field value
        /// </summary>
        // Use this for initialization
        private void Start()
        {
            // For testing
            w = new TurretWheelObject();

            PlayerCurrency.Value = startingCurrency;
        }
        
        /// <summary>
        /// Does some checks to see if player is clicking on a tile. If so, spawn current turret.
        /// Else, return.
        /// </summary>
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

        /// <summary>
        /// Control the current index of the turret selector. Scrolling mouse wheel changes it.
        /// </summary>
        private void Update()
        {
            if (Input.mouseScrollDelta.y > 0)
                w.Up();
            if (Input.mouseScrollDelta.y < 0)
                w.Down();
            CurrentTurretIndex.Value = w.Index;
        }
        
        /// <summary>
        /// Implementation of IWheelObject for this class to use.
        /// </summary>
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