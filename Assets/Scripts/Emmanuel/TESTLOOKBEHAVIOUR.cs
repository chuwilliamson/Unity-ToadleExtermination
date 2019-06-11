using System.Collections;
using UnityEngine;

//ToDo:: IDK HOW TF THIS WORKS IF IT DO
public class TESTLOOKBEHAVIOUR : MonoBehaviour
{
	private Vector3 mousePositionInWorld;

	private Vector3 targetPos;

	public GameObject prefab;

	public bool movePrefab = false;

	void Awake()
	{
		if (prefab)
		{
			prefab.layer = 2;
		}
		else
		{
			Debug.Log("No Prefab Assigned");
		}
	}
	// Update is called once per frame
	void Update ()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit rayCastHit;
		if (Physics.Raycast(ray, out rayCastHit, Mathf.Infinity))
		{
			mousePositionInWorld = rayCastHit.point;
			CalculateTargetPosition(rayCastHit.point);
			if (movePrefab && prefab)
				prefab.transform.position = targetPos;
		}
		Debug.DrawLine(transform.position, mousePositionInWorld, Color.red);
		Debug.DrawLine(transform.position, targetPos, Color.yellow);
	}

	void CalculateTargetPosition(Vector3 hit)
	{
		Vector3 mouse_ScreenToWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float y_total = hit.y - mouse_ScreenToWorld.y;
		float newY = (y_total - (hit.y - transform.position.y));

		float factor = newY / y_total;
		targetPos = mouse_ScreenToWorld + ((hit - mouse_ScreenToWorld) * factor);
	}
}
