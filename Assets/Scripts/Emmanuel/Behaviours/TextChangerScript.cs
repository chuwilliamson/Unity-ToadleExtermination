using System.Collections;
using System.Collections.Generic;
using Steffan.Behaviours;
using UnityEngine;
using UnityEngine.UI;

public class TextChangerScript : MonoBehaviour
{
	public Text textObject;
	public PlayerDataBehaviour pdBehavoiur;
	
	// Use this for initialization
	void Start ()
	{
		textObject.text = pdBehavoiur.pd.Currency.ToString();
	}
	
	// Update is called once per frame
	void Update () 
	{
		textObject.text = pdBehavoiur.pd.Currency.ToString();
	}
}
