using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendTriggerToAnimatorBehaviour : MonoBehaviour
{
	//must assign this in inspector
	public Animator animator;
/// <summary>
/// assign this function to a gameeventlistener-> response to start an animation via trigger
/// </summary>
/// <param name="triggerValue">trigger condition of the transition</param>
	public void SendValueToAnimator(string triggerValue)
	{
		animator.SetTrigger(triggerValue);
	}
}
