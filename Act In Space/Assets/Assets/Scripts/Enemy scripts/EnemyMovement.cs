using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

	private Transform Target;
	Vector3 destination;
	NavMeshAgent Agent;


	// Use this for initialization
	void Start () 
	{
		Agent = GetComponent<NavMeshAgent> ();
		Target = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Agent.destination = Target.position;
	}
}
