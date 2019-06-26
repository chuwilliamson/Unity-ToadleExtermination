using System;
using System.Collections;
using System.Collections.Generic;
using Matthew;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.XR.WSA.Input;

namespace Emmanuel
{
	public class PlayerTongueAttackBehaviour: MonoBehaviour
	{
		[SerializeField]
		private GameEvent OnTriggerEnterEvent;
		//use this to reset the scale back
		private Transform resetTransform;

		[SerializeField] private Transform cursorTransform;
		
		private float maximumZScale;
		private float minimumZScale;
		
		public float extendSpeed;
		public float retractSpeed;

		private string motionState;
		
		public string collisionTargetTag;
		public string cursorTag;

		private bool hasHitSomething;

		public bool HasHitSomething { get { return hasHitSomething; } set { hasHitSomething = value; } }

		// Use this for initialization
		void Start()
		{
			resetTransform = transform;
			
			maximumZScale = 6.3f;
			minimumZScale = 0.2f;

			transform.localScale.Set(transform.localScale.x, transform.localScale.y, minimumZScale); //reset scale
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
			transform.localScale += new Vector3(0,0, extendSpeed * Time.deltaTime);
		}

		//retracts the tongue in
		void Retract()
		{
			transform.localScale += new Vector3(0,0, -(retractSpeed * Time.deltaTime));
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

			if (motionState == "Idle")//if in idle state
			{
				hasHitSomething = false;//it hasn't hit anything
				if (Input.GetMouseButtonDown(0))//click to set the motionState to extending
				{
					motionState = "Extending";
				}
			}
			else if (hasHitSomething)//if it hit something
			{
				motionState = "Retracting";
			}
			else //if not idle, and hasn't hit anything
			{
				if ( transform.localScale.z >= maximumZScale ) //if past max z scale
				{
					motionState = "Retracting";
				}
			}

			if ( transform.localScale.z < minimumZScale ) //if past min Z scale
			{
				transform.localScale += new Vector3(0,0, 0.2f);
				
				motionState = "Idle";
			}

			return motionState;
		}
		void OnTriggerEnter(Collider other)
		{
			if ( other.gameObject.CompareTag(collisionTargetTag) )
			{
				hasHitSomething = true;
				OnTriggerEnterEvent.Raise(this);
			}
				
			
			if ( other.gameObject.CompareTag(cursorTag) )
				hasHitSomething = true;
		}
	}

}
