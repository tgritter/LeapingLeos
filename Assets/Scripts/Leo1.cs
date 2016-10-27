using UnityEngine;
using System.Collections;

public class Leo1 : MonoBehaviour {

	Vector3 pos = new Vector3 (0, 1.5F, 0);
	Vector3 pos2 = new Vector3 (20, 1.5F, 0);
	Vector3 jumpForce = new Vector3 (0, 200, 0);
	float speed = 12F;
	float spinTime = 20F;
	float originX = 10;
	float originZ = 0F;
	float radius = 10F;
	public Rigidbody Leo1RB;
	float midX;
	float midZ;
	Vector3 midpoint = new Vector3 (0, 0, 0);

	public GameObject Leo2;



	// Use this for initialization
	void Start () {
		this.transform.position = pos;
		Leo2.transform.position = pos2;
		Leo1RB = GetComponent<Rigidbody>();

	}

	void circleCounterClockwise() {
		/*
		pos.x = radius * Mathf.Cos (2 * Mathf.PI * spinTime / 1000) + originX;
		pos.z = radius * Mathf.Sin (2 * Mathf.PI * spinTime / 1000) + originZ;

		pos2.x = -radius * Mathf.Cos (2 * Mathf.PI * spinTime / 1000) + originX;
		pos2.z = -radius * Mathf.Sin (2 * Mathf.PI * spinTime / 1000) + originZ;

		pos.y = this.transform.position.y;
		pos2.y = Leo2.transform.position.y;

		this.transform.position = pos;
		Leo2.transform.position = pos2;
		*/
		midX = (this.transform.position.x + Leo2.transform.position.x) / 2F;
		midZ = (this.transform.position.z + Leo2.transform.position.z) / 2F;
		midpoint.x = midX;
		midpoint.z = midZ;
		midpoint.y = this.transform.position.y;
		print (midpoint);
		this.transform.RotateAround (midpoint, Vector3.up, speed/6F);
		Leo2.transform.RotateAround (midpoint, Vector3.up, speed/6F);

	}

	void circleClockwise() {
		midX = (this.transform.position.x + Leo2.transform.position.x) / 2F;
		midZ = (this.transform.position.z + Leo2.transform.position.z) / 2F;
		midpoint.x = midX;
		midpoint.z = midZ;
		midpoint.y = this.transform.position.y;
		this.transform.RotateAround (midpoint, Vector3.up, -(speed/6F));
		Leo2.transform.RotateAround (midpoint, Vector3.up, -(speed/6F));


	}

	void closer() {
		midX = (this.transform.position.x + Leo2.transform.position.x) / 2F;
		midZ = (this.transform.position.z + Leo2.transform.position.z) / 2F;
		midpoint.x = midX;
		midpoint.z = midZ;
		midpoint.y = this.transform.position.y;

		this.transform.LookAt (midpoint);
		Leo2.transform.LookAt (midpoint);
		this.transform.Translate (Vector3.forward);
		Leo2.transform.Translate (Vector3.forward);
		radius -= 1;
	}

	void widen() {
		midX = (this.transform.position.x + Leo2.transform.position.x) / 2F;
		midZ = (this.transform.position.z + Leo2.transform.position.z) / 2F;
		midpoint.x = midX;
		midpoint.z = midZ;
		midpoint.y = this.transform.position.y;

		this.transform.LookAt (midpoint);
		Leo2.transform.LookAt (midpoint);
		this.transform.Translate (Vector3.back);
		Leo2.transform.Translate (Vector3.back);
		radius += 1;
	}




	// Update is called once per frame
	void Update () {



		if (Input.GetKey ("d")) {
			this.transform.Translate (0.1F * speed, 0, 0, Space.World);
			Leo2.transform.Translate (0.1F * speed, 0, 0,Space.World);
			originX += 0.1F * speed;


		}
		if (Input.GetKey ("a")) {
			this.transform.Translate (-(0.1F * speed), 0, 0,Space.World);
			Leo2.transform.Translate (-(0.1F * speed), 0, 0,Space.World);
			originX -= 0.1F * speed;

		}
		if (Input.GetKey ("w")) {
			this.transform.Translate (0,0,0.1F * speed,Space.World);
			Leo2.transform.Translate (0,0,0.1F * speed,Space.World);
			originZ += 0.1F * speed;
			

		}
		if (Input.GetKey ("s")) {
			this.transform.Translate (0,0,-(0.1F * speed),Space.World);
			Leo2.transform.Translate (0,0,-(0.1F * speed),Space.World);
			originZ -= 0.1F * speed;

		}
		if(Input.GetKey("right")){
			spinTime += speed;
			circleCounterClockwise ();
		}

		if (Input.GetKey ("left")) {
			spinTime -= speed;
			circleClockwise ();
		}
		if (Input.GetKey ("up")) {
			radius += 0.1F * speed;
			widen ();
		}
		if (Input.GetKey ("down")) {
			radius -= 0.1F * speed;
			closer ();
		}



		//circle ();



	}


}
