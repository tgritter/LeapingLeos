using UnityEngine;
using System.Collections;

public class LogController : MonoBehaviour {
	public float logspeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z >= 0f) {
			this.transform.Translate (Vector3.back * logspeed, Space.World);
		}
	}
}
