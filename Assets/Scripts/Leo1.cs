﻿using UnityEngine;
using System.Collections;

public class Leo1 : MonoBehaviour {

	Vector3 pos = new Vector3 (0, 0, 0);
	Vector3 pos2 = new Vector3 (20, 0, 0);
	float speed = 12F;
	float spinTime = 20F;
	float originX = 10;
	float originZ = 0F;
	float radius = 10F;



	public GameObject Leo2;



	// Use this for initialization
	void Start () {
		this.transform.position = pos;
		Leo2.transform.position = pos2;
	}

	void circle() {

		pos.x = radius * Mathf.Cos (2 * Mathf.PI * spinTime / 1000) + originX;
		pos.z = radius * Mathf.Sin (2 * Mathf.PI * spinTime / 1000) + originZ;

		pos2.x = -radius * Mathf.Cos (2 * Mathf.PI * spinTime / 1000) + originX;
		pos2.z = -radius * Mathf.Sin (2 * Mathf.PI * spinTime / 1000) + originZ;


		this.transform.position = pos;
		Leo2.transform.position = pos2;

	}


	// Update is called once per frame
	void Update () {

		if(Input.GetKey("right")){
			circle ();
			spinTime += speed;
		}

		if (Input.GetKey ("left")) {
			circle ();
			spinTime -= speed;
		}
		if (Input.GetKey ("d")) {
			pos.x += 0.1F * speed;
			pos2.x += 0.1F * speed;
			originX += 0.1F*speed;
			this.transform.position = pos;
			Leo2.transform.position = pos2;

		}
		if (Input.GetKey ("a")) {
			pos.x -= 0.1F * speed;
			pos2.x -= 0.1F * speed;
			originX -= 0.1F* speed;
			this.transform.position = pos;
			Leo2.transform.position = pos2;
		}
		if (Input.GetKey ("w")) {
			pos.z += 0.1F * speed;
			pos2.z += 0.1F * speed;
			originZ += 0.1F* speed;
			this.transform.position = pos;
			Leo2.transform.position = pos2;
		}
		if (Input.GetKey ("s")) {
			pos.z -= 0.1F * speed;
			pos2.z -= 0.1F * speed;
			originZ -= 0.1F* speed;
			this.transform.position = pos;
			Leo2.transform.position = pos2;
		}
		if (Input.GetKey ("up")) {
			radius += 0.1F * speed;
		}
		if (Input.GetKey ("down")) {
			radius -= 0.1F * speed;
		}



	}
}
