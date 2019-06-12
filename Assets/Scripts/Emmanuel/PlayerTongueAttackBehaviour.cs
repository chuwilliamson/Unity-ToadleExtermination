using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Emmanuel
{
	public class PlayerTongueAttackBehaviour: MonoBehaviour
	{
		public Animation animation;

		// Use this for initialization
		void Start()
		{
			animation = GetComponent<Animation>();
			foreach (AnimationState state in animation)
			{
				state.speed = 0.5f;
			}
		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}
