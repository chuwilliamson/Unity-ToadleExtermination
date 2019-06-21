using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputBehaviour : MonoBehaviour
{
	public UnityEvent spaceResponse;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			spaceResponse.Invoke();
		}
	}
}
