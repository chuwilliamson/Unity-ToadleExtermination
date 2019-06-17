using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.XR.WSA.Input;

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
		
		public string collisionTargetTag;
		public string cursorTag;
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

			if (motionState == "Idle")
			{
				if (Input.GetMouseButtonDown(0))
				{
					motionState = "Extending";
				}
			}
			else if (transform.localScale.z >= maximumZScale)
			{
				motionState = "Retracting";
			}
			else if (transform.localScale.z < minimumZScale)
			{
				transform.localScale.Set(transform.localScale.x, transform.localScale.y, minimumZScale);

				motionState = "Idle";
			}

			return motionState;
		}
		private void OnTriggerEnter(Collider other)
		{
			if ( other.gameObject.CompareTag(collisionTargetTag) )
				motionState = "Retracting";	
			if ( other.gameObject.CompareTag(cursorTag))
				Debug.Log("hit the cursor");

				motionState = "Retracting";
			if ( other.gameObject.CompareTag("Player") )
				return;
			
		}
	}

}
