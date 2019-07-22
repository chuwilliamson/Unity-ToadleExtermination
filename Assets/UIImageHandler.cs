using System.Collections;
using System.Collections.Generic;
using Emmanuel.Interfaces;
using Emmanuel.ScriptableObjects;
using Steffan.Behaviours;
using UnityEngine;
using UnityEngine.UI;

public class UIImageHandler : MonoBehaviour
{
	public IntVariable CurrentTurretIndex;
	public RawImage CurrentTurretIcon;
	public Image HealthBar;
	public RawImage TadpoleSprite;
	public RawImage CrawfishSprite;
	
	//Type is SpriteArray
		// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (CurrentTurretIndex.Value == 0)
			CurrentTurretIcon = TadpoleSprite;
		else
			CurrentTurretIcon = CrawfishSprite;
	}
}