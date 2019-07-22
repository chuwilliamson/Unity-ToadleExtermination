using System.Collections;
using System.Collections.Generic;
using Emmanuel.ScriptableObjects;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UITextHandler : MonoBehaviour
{

	public Text CurrencyText;
	public Text ScoreText;

	public IntVariable PlayerCurrency;
	public IntVariable Score;
	// Use this for initialization
	void Start ()
	{
		CurrencyText.text = "0";
		ScoreText.text = "0";
	}
	
	// Update is called once per frame
	void Update ()
	{
		CurrencyText.text = PlayerCurrency.Value.ToString();
		ScoreText.text = Score.Value.ToString();
	}
}
