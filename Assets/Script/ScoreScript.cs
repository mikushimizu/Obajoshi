using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	public Text Scorelabel;
	public static int playerHP = 10;

	void Start () {
		
	}

	void Update () {
		if (GameManagerScript.end == false) {
			Scorelabel.text = "SCORE:" + playerHP.ToString ();
		}
	}
}
