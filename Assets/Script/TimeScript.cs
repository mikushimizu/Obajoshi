using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
	public static float countTime = 90;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (countTime >= 0) {
			countTime -= Time.deltaTime;
			GetComponent<Text> ().text = "TIME:" + countTime.ToString ("F0");
		}
	}
}
