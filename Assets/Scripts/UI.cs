﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour
{
	public Text scoreTxt;
	public Text killedTxt;
	public Text timeTxt;

	public Slider healthBar;
	public Text hpTxt;

	void Update ()
	{
		scoreTxt.text = "Score : " + Game.score;
		killedTxt.text = "Killed : " + Game.killed;
		timeTxt.text = "Time : " + (int)Game.time;
		healthBar.value = Player.currHp;
		healthBar.maxValue = Player.maxHp;

		if (Player.currHp < 0)
		{
			hpTxt.text = "0 / " + Player.maxHp;
		}
		else
		{
			hpTxt.text = Player.currHp + " / " + Player.maxHp;
		}
	}
}
