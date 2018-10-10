using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
	public GameObject enemy;

	void Start () {
		InvokeRepeating ("Generate", 0, 5);
	}

	void Update () {
	}

	void Generate(){
		Instantiate (enemy, transform.position, transform.rotation);
	}
}
