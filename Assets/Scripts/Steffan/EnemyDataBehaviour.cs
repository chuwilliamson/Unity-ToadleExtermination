using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDataBehaviour : MonoBehaviour
{
	public Emmanuel.EnemyData ed;
	// Use this for initialization
	void Start ()
	{
		ed = Instantiate(ed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
