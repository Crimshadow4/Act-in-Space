using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	//public PlayerHealth 
	public float spawnTime = 5f;
	public Transform[] spawnPoints;
	public GameObject enemy;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void Spawn()
	{
		//if playerhealth == 0 or all totems destroyed stop spawning

		//randomspawn
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);

		Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
	}
}
