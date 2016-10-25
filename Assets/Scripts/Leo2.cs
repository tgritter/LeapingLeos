using UnityEngine;
using System.Collections;

public class Leo2 : MonoBehaviour {

	Vector3 pos = new Vector3 (0, 0, 0);
	float speed = 12F;
	float spinTime = 20F;
	float originX = 10F;
	float originZ = 0F;


	// Use this for initialization
	void Start () {
		this.transform.position = pos;
	}

	void circle() {

		pos.x = -10 * Mathf.Cos (2 * Mathf.PI * spinTime / 1000) + originX;
		pos.z = -10 * Mathf.Sin (2 * Mathf.PI * spinTime / 1000) + originZ;

		this.transform.position = pos;
		print (pos.x);
		print (pos.y);


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
			originX += 0.1F*speed;
			this.transform.position = pos;

		}
		if (Input.GetKey ("a")) {
			pos.x -= 0.1F * speed;
			originX -= 0.1F* speed;
			this.transform.position = pos;
		}
		if (Input.GetKey ("w")) {
			pos.z += 0.1F * speed;
			originZ += 0.1F* speed;
			this.transform.position = pos;
		}
		if (Input.GetKey ("s")) {
			pos.z -= 0.1F * speed;
			originZ -= 0.1F* speed;
			this.transform.position = pos;
		}




	}
}
