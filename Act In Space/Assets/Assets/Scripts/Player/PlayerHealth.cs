using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth: MonoBehaviour {

	public int startingHealth = 10;
	public int currentHealth;

	bool damaged;

	// Use this for initialization
	void Start () 
	{
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (damaged) 
		{
			//do color stuff for polish later
		} else 
		{
			//turn color back here
		}
		damaged = false;
	}
	public void playerDamage (int amount)
	{
		damaged = true;

		currentHealth -= amount;

		if (currentHealth <= 0) 
		{
			//do dead stuff
		}
	}
}
