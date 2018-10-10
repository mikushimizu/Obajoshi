using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectGenerater : MonoBehaviour {
	public GameObject treeA;
	public GameObject treeB;
	public GameObject heart;
	public GameObject grassA;
	public GameObject grassB;

	void Start () {
		for (int i = 0; i < 50; i++) {
			float x = Random.Range (-120, 75);
			float z = Random.Range (57, 200);
			Instantiate (treeA, new Vector3 (x, 0, z), Quaternion.Euler(-90, 0, 0));
		}
		for (int i = 0; i < 50; i++) {
			float x = Random.Range (-120, 75);
			float z = Random.Range (57, 200);
			Instantiate (treeB, new Vector3 (x, 0, z), Quaternion.Euler(-90, 0, 0));
		}
		for (int i = 0; i < 25; i++) {
			float x = Random.Range (-120, 75);
			float z = Random.Range (57, 200);
			Instantiate (heart, new Vector3 (x, 3.5f, z), Quaternion.Euler(-90, 0, 0));
		}
		for (int i = 0; i < 150; i++) {
			float x = Random.Range (-120, 75);
			float z = Random.Range (57, 200);
			Instantiate (grassA, new Vector3 (x, 0, z), Quaternion.Euler(-90, 0, 0));
		}
		for (int i = 0; i < 150; i++) {
			float x = Random.Range (-120, 75);
			float z = Random.Range (57, 200);
			Instantiate (grassB, new Vector3 (x, 0, z), Quaternion.Euler(-90, 0, 0));
		}
	}

	void Update () {
		
	}
}
