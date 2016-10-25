using UnityEngine;
using System.Collections;

public class Leo1 : MonoBehaviour {

	Vector3 pos = new Vector3 (1, 0, 0);
	float speed = 12F;
	float spinTime = 20F;


	// Use this for initialization
	void Start () {
		this.transform.position = pos;
	}

	void circle() {

		pos.x = 10 * Mathf.Cos (2 * Mathf.PI * spinTime / 1000);
		pos.z = 10 * Mathf.Sin (2 * Mathf.PI * spinTime / 1000);

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



	}
}
