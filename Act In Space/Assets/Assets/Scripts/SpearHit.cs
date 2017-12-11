using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearHit : MonoBehaviour {

	public GameObject Score;
	public ScoreHealth scoreHealth;
	private GameObject ThrustStatus;

	// Use this for initialization
	void Start () {
		scoreHealth = Score.GetComponent<ScoreHealth> ();
		ThrustStatus = GameObject.FindGameObjectWithTag ("Player").transform.GetChild (2).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider SpearHitsEnemy)
	{
		if (ThrustStatus.activeSelf == true) 
		{
			
			if (SpearHitsEnemy.gameObject.tag == "Enemy")
			{
				Destroy (SpearHitsEnemy.gameObject);
				scoreHealth.ScoreCount += 50;

			}

			if (SpearHitsEnemy.gameObject.tag == "Totem") 
			{
				SpearHitsEnemy.transform.SendMessage ("TakeDamage", 1);
			}
		}
	}
}
