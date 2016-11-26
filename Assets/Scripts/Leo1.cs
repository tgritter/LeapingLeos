using UnityEngine;
using System.Collections;

public class Leo1 : MonoBehaviour {

	Vector3 pos;
	Vector3 pos2;
	Vector3 jumpForce = new Vector3 (0, 200, 0);
	public float speed;
	float midX;
	float midZ;
	float jumpTime = 0f;
	bool grounded = true;
	Vector3 midpoint = new Vector3 (0, 0, 0);

	public GameObject Leo2;



	// Use this for initialization
	void Start () {
		


	}

	void circleCounterClockwise() {

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
		this.transform.Translate (Vector3.forward*speed);
		Leo2.transform.Translate (Vector3.forward*speed);

	}

	void widen() {
		midX = (this.transform.position.x + Leo2.transform.position.x) / 2F;
		midZ = (this.transform.position.z + Leo2.transform.position.z) / 2F;
		midpoint.x = midX;
		midpoint.z = midZ;
		midpoint.y = this.transform.position.y;

		this.transform.LookAt (midpoint);
		Leo2.transform.LookAt (midpoint);
		this.transform.Translate (Vector3.back*speed);
		Leo2.transform.Translate (Vector3.back*speed);

	}

	void jump () {
		
	}

	// Update is called once per frame
	void Update () {

		grounded = this.transform.position.y == 30f;

		if (Input.GetKey ("d")) {
			this.transform.Translate (speed, 0, 0, Space.World);
			Leo2.transform.Translate (speed, 0, 0,Space.World);


		}
		if (Input.GetKey ("a")) {
			this.transform.Translate (-(speed), 0, 0,Space.World);
			Leo2.transform.Translate (-(speed), 0, 0,Space.World);

		}
		if (Input.GetKey ("w")) {
			this.transform.Translate (0,0,speed,Space.World);
			Leo2.transform.Translate (0,0,speed,Space.World);

			

		}
		if (Input.GetKey ("s")) {
			this.transform.Translate (0,0,-(speed),Space.World);
			Leo2.transform.Translate (0,0,-(speed),Space.World);


		}
		if(Input.GetKey("right")){
			circleCounterClockwise ();
		}

		if (Input.GetKey ("left")) {

			circleClockwise ();
		}
		if (Input.GetKey ("up")) {
			widen ();
		}
		if (Input.GetKey ("down")) {
			closer ();
		}
		if (Input.GetKey ("space") && grounded) {
			grounded = false;

		}
		if (!grounded) {
			jump ();
		} 




		//circle ();



	}


}
