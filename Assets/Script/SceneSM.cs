﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSM : MonoBehaviour {
	void Start () {
		
	}

	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			SceneManager.LoadScene ("Main");
		}
	}
}
