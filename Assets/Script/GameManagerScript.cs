using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManagerScript : MonoBehaviour {
	public Text finish;
	public Text esc;
	public AudioSource BGM;
	public Camera normalCamera;
	public Camera clearCamera;
	public GameObject Generator;
	public static bool end = false;

	void Start () {
		finish.gameObject.SetActive (false);
		esc.gameObject.SetActive (false);
		BGM.Play ();
	}

	void Update () {
		if (TimeScript.countTime <= 0) {
			Finish ();
			Destroy (Generator.gameObject);
		}
		if (PlayerController.playerHP <= 0) {
			PlayerController.playerHP = 0;
		}

	}

	public void Finish(){
		Debug.Log ("Finish");
		end = true;
		finish.gameObject.SetActive (true);
		esc.gameObject.SetActive (true);
		normalCamera.gameObject.SetActive (false);
		clearCamera.gameObject.SetActive (true);
	}
}
