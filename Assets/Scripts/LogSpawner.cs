using UnityEngine;
using System.Collections;

public class LogSpawner : MonoBehaviour {

	public GameObject log;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnLog", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void SpawnLog()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (log, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);

	}
}
