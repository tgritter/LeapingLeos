using UnityEngine;
using System.Collections;

public class LogScript : MonoBehaviour {
	Vector3 pos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		pos = this.transform.position; 
		pos.z -= 0.1f;
		this.transform.position = pos;
	
	}
}
