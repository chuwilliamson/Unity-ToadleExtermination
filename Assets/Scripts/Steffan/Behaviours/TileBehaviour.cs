using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileBehaviour : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler,IPointerExitHandler
{
	public Color defaultColor;
	public MeshRenderer meshRenderer;

	private bool _hasTurret;

	public void Start()
	{
		meshRenderer = GetComponent<MeshRenderer>();
		defaultColor = meshRenderer.material.color;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		EventSystem.current.SetSelectedGameObject(gameObject);
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		meshRenderer.material.color = Color.green;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		meshRenderer.material.color = defaultColor;
	}
}
