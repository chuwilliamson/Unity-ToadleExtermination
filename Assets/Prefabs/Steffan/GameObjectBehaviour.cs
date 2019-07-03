using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameObjectBehaviour : MonoBehaviour {
    public void SetDestination(Transform trans)
    {
        GetComponent<NavMeshAgent>().SetDestination(trans.position);
    }
	// Use this for initialization
	void Start () {
		
	}
    public UnityEngine.Events.UnityEvent Response;
	// Update is called once per frame
	void Update () {
        Response.Invoke();
	}
}
