using UnityEngine;
using System.Collections;

public class Leo1 : MonoBehaviour {
	Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = this.transform.position; 
		pos.x += 5;
		this.transform.position += pos;
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("left")){
			
		pos = this.transform.position; 
		pos.x += 1;
		this.transform.position += pos;
		}


	}
}
