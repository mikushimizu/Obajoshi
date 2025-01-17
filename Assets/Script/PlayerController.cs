﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public AudioSource D1;
	public AudioSource E1;
	public AudioSource F1;
	public AudioSource G1;
	public AudioSource A1;
	public AudioSource B1;
	public AudioSource C1;
	public AudioSource D2;
	public AudioSource E2;
	public AudioSource F2;
	public AudioSource G2;
	public AudioSource A2;
	public AudioSource B2;
	public AudioSource C2;
	public AudioSource D3s;
	public AudioSource Heart;
	public AudioSource Damage;

	Rigidbody rb;
	public static int playerHP = 10;
	public static float pos_y;
	public static int enemyCount = 0;
	private Animator animator;
	private Vector3 velocity;
	[SerializeField]
	private float jumpPower = 5f;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void Update () {
		if (GameManagerScript.end == false) {　//ゲーム中は
			pos_y = transform.position.y;
			if (Input.GetKey ("up")) { //前進
				transform.position += transform.forward * 0.2f;
				animator.SetBool ("is_running", true);
			} else {
				animator.SetBool ("is_running", false);
			}
			if (Input.GetKey ("right")) {　//右回り
				transform.Rotate (0, 4, 0);
				animator.SetBool ("is_right", true);
			} else {
				animator.SetBool ("is_right", false);
			}
			if (Input.GetKey ("left")) { //左回り
				transform.Rotate (0, -4, 0);
				animator.SetBool ("is_left", true);
			} else {
				animator.SetBool ("is_left", false);
			}
			if (Input.GetKeyDown ("down")) { //後ろを向く
				transform.Rotate (0, 180, 0);
			}
			if (pos_y <= 1.7f) {
				if (Input.GetKeyDown (KeyCode.Space)) { //ジャンプ
					animator.SetBool ("is_jumping", true);
					this.GetComponent<Rigidbody> ().AddForce (0, 300f, 0);
				} else {
					animator.SetBool ("is_jumping", false);
				}
			}
		} else {
			animator.SetBool ("is_finish", true);
		}
	}

	void OnCollisionEnter(Collision collision){
		//ハートに触れたとき
		if (collision.gameObject.tag == "Heart") {
			Heart.Play ();
			Debug.Log("heart");
			collision.gameObject.SetActive(false);
			ScoreScript.playerHP += 10;
		}

		//キノコにぶつかったとき
		if (collision.gameObject.tag == "Enemy") {
			Damage.Play ();
			Debug.Log("ita!");
			ScoreScript.playerHP--;
		}

		//キノコの頭を踏んだ時
		if (collision.gameObject.tag == "Touch") {
			enemyCount++;
			Debug.Log("enemyCount:" + enemyCount);

			if (enemyCount == 1) {
				D1.Play ();
			}else if (enemyCount == 2) {
				E1.Play ();
			}else if (enemyCount == 3) {
				F1.Play ();
			}else if (enemyCount == 4) {
				G1.Play ();
			}else if (enemyCount == 5) {
				A1.Play ();
			}else if (enemyCount == 6) {
				B1.Play ();
			}else if (enemyCount == 7) {
				C1.Play ();
			}else if (enemyCount == 8) {
				D2.Play ();
			}else if (enemyCount == 9) {
				E2.Play ();
			}else if (enemyCount == 10) {
				F2.Play ();
			}else if (enemyCount == 11) {
				G2.Play ();
			}else if (enemyCount == 12) {
				A2.Play ();
			}else if (enemyCount == 13) {
				B2.Play ();
			}else if (enemyCount == 14) {
				C2.Play ();
			}else if (enemyCount >= 15) {
				D3s.Play ();
			}
			collision.gameObject.GetComponentInParent<EnemyScript> ().SendMessage ("Damage");
		}

		if (collision.gameObject.tag == "Field") {
			enemyCount = 0;
			Debug.Log("COMBO"+ enemyCount);
		}

	}




}