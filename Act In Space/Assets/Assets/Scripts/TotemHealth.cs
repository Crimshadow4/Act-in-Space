using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotemHealth : MonoBehaviour {

	public int StartingHealth = 5;
	public int CurrentHealth;
	public GameObject Score;
	public ScoreHealth scoreHealth;


	// Use this for initialization
	void Start () 
	{
		scoreHealth = Score.GetComponent<ScoreHealth> ();
		CurrentHealth = StartingHealth;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (CurrentHealth < 1) 
		{
			Destroy (gameObject);
			scoreHealth.ScoreCount += 500;
		}
	}

	public void TakeDamage(int amount)
	{
		CurrentHealth -= amount;
	}
}
