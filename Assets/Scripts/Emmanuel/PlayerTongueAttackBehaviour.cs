using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Emmanuel
{
	public class PlayerTongueAttackBehaviour: MonoBehaviour
	{
		//use this to reset the scale back
		private Transform resetTransform;

		[SerializeField] private Transform cursorTransform;
		
		private float maximumZScale;
		private float minimumZScale;
		
		public float extendSpeed;
		public float retractSpeed;

		private string motionState;
		
		// Use this for initialization
		void Start()
		{
			resetTransform = transform;
			maximumZScale = 6.3f;
			minimumZScale = resetTransform.localScale.z;

			motionState = "Idle";
		}

		// Update is called once per frame
		void  Update()
		{
			Move( StateCheck() );
		}

		//extends the tongue out
		void Extend()
		{
			Debug.Log("now extending");
			transform.localScale.Set(transform.localScale.x, transform.localScale.y, transform.localScale.z + extendSpeed);
			Debug.Log("set the local scale");
		}

		//retracts the tongue in
		void Retract()
		{
			transform.localScale.Set(transform.localScale.x, transform.localScale.y, transform.localScale.z - retractSpeed);
		}
		
		//controls how the tongue will behave
		void Move(string state)
		{
			if (state == "Extending")
			{
				Extend();
			}
			else if (state == "Retracting")
			{
				Retract();
			}
		}

		//controls the state of the tongue
		string StateCheck()
		{
			if (motionState == "Idle")
			{
				if (Input.GetMouseButtonDown(0))
				{
					Debug.Log("Mouse Click Recognized");
					Debug.Log("StateChange:: Now Extending");

					motionState = "Extending";
				}
			}
			else if (transform.localScale.z >= maximumZScale)
			{
				Debug.Log("StateChange:: Now Retracting");
				motionState = "Retracting";
			}
			else if (transform.localScale.z < minimumZScale)
			{
				transform.localScale.Set(transform.localScale.x, transform.localScale.y, minimumZScale);
				Debug.Log("StateChange:: Now Idle");

				motionState = "Idle";
			}

			return motionState;
		}
	}
}
