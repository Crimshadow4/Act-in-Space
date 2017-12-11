using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	public float TimeBetweenAttacks = 0.5f;
	public int AttackDamage = 1;

	GameObject player;
	PlayerHealth playerHealth;
	bool playerInRange;
	float timer;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;

		if (timer >= TimeBetweenAttacks && playerInRange == true) 
		{
			Attack ();
		}
	}

	void OnTriggerEnter(Collider EnemyHit)
	{
		if (EnemyHit.gameObject.tag == "Player") 
		{
			playerInRange = true;
		}
	}

	void OnTriggerExit(Collider EnemyHit)
	{
		if (EnemyHit.gameObject.tag == "Player") 
		{
			playerInRange = false;
		}
	}

	void Attack()
	{
		timer = 0f;

		playerHealth.playerDamage (AttackDamage);
	}

}
