using System.Collections;
using System.Collections.Generic;
using Emmanuel.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Steffan.Behaviours
{
	public class TestWheelObject : IWheelObject
	{
		public void Up()
		{
			throw new System.NotImplementedException();
		}

		public void Down()
		{
			throw new System.NotImplementedException();
		}

		public Object Current
		{
			get { return GameObject.CreatePrimitive(PrimitiveType.Cube); }
		}
	}

	public class TurretPlacementBehaviour : MonoBehaviour
	{
		[SerializeField]
		private IWheelObject w;
		// Use this for initialization
		void Start () {
			// For testing
		w = new TestWheelObject();
		}
	
		// Update is called once per frame
		public void Update () {
		
		}

		private void PlaceTurret()
		{
			var pos = EventSystem.current.transform.position;
			var t = Instantiate(w.Current, pos, Quaternion.identity) as GameObject;
			

		}
		
	}
}