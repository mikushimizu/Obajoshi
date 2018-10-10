using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerStart : MonoBehaviour {
	private Animator animator;
	public AudioSource start; 
	void Start () {
		animator = GetComponent<Animator> ();
		start.Play ();

	}

	void Update () {
		
	}
}
