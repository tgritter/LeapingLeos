using UnityEngine;
using System.Collections;



public class Leo2 : MonoBehaviour {

	public Rigidbody Leo2RB;
	Vector3 pos = new Vector3 (0,0,0);
	float speed = 12F;
	float spinTime = 20F;
	float originX = 10F;
	float originZ = 0F;
	Vector3 jumpForce = new Vector3 (0, 6000, 0);


	// Use this for initialization
	void Start () {
		Leo2RB = GetComponent<Rigidbody>(); 
	}
		
	// Update is called once per frame
	void Update () {
		pos = this.transform.position;

		if (Input.GetKey ("space")) {
			print("spacebar");
			if (pos.y <= 1.55) {
				Leo2RB.AddForce (jumpForce);
			}

		}

	}
}
