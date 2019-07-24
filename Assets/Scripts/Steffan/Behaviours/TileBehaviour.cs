using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// This is purely to keep track of whether or not a given tile already has a turret.
/// Also determines the current material of the tile, changing on hover
/// </summary>
public class TileBehaviour : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler,IPointerExitHandler
{
	public Material defaultMaterial;
	public MeshRenderer meshRenderer;
	public Material greenHighlight;

	private bool _hasTurret;

	public bool HasTurret
	{
		get { return _hasTurret; }
		set { _hasTurret = value; }
	}


	public void Start()
	{
		meshRenderer = GetComponent<MeshRenderer>();
		defaultMaterial = meshRenderer.material;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		EventSystem.current.SetSelectedGameObject(gameObject);
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		meshRenderer.material = greenHighlight;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		meshRenderer.material = defaultMaterial;
	}
}
