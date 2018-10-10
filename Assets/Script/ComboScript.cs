using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboScript : MonoBehaviour {
	public Text Combolabel;

	void Start () {

	}

	void Update () {
		Combolabel.text = "COMBO:" + PlayerController.enemyCount.ToString ();
	}
}
