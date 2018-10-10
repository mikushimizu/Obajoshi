using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour {
	public Transform target;
	public GameObject Attack;
	NavMeshAgent agent;

	void Start () {
		GameObject player = GameObject.Find ("kamamiTest");
		target = player.transform;
		agent = GetComponent<NavMeshAgent> ();
		
	}

	void Update () {
		agent.SetDestination (target.position);
	}

	public void Damage(){
		//敵を消す
		ScoreScript.playerHP = ScoreScript.playerHP + PlayerController.enemyCount*10;
		Destroy (this.gameObject);
		Instantiate (Attack, transform.position, transform.rotation);
	}
}
