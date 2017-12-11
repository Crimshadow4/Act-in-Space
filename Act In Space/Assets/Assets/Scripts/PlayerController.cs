using UnityEngine;
using System.Collections;
using System.Collections.Generic;

enum Direction
{
    Up,
    Right,
    Down,
    Left
}
public class PlayerController : MonoBehaviour
{
	public float speed = 1;
	public int Health = 10;
    Direction currentDirection;

	//gameobjects to load for attack animation


	//variables for atacking
	private bool Attack = false;
	private int Attackcnt = 0;

	CharacterController controller;

    void Start()
    {
		//loading the gameobjects
		//TODO: change this to one gameobject that we overload each time. I needed seperate calls to understand what I was doing at the time.



    }

    void Update()
    {
		controller = gameObject.GetComponent<CharacterController>();

        var x = Input.GetAxisRaw("Horizontal") * speed;
        var z = Input.GetAxisRaw("Vertical") * speed;

		if (Attack == false) 
		{
	        if (x < 0)
	        {
	            SetDirection(Direction.Up);
	            currentDirection = Direction.Up;
	        }
	        if (x > 0)
	        {
	            SetDirection(Direction.Down);
	            currentDirection = Direction.Down;
	        }
	        if (z > 0)
	        {
	            SetDirection(Direction.Left);
	            currentDirection = Direction.Left;
	        }
	        if (z < 0)
	        {
	            SetDirection(Direction.Right);
	            currentDirection = Direction.Right;
	        }

				//transform.position += new Vector3 (x, 0, z);

			controller.Move(new Vector3(x, 0, z));
			//attack on spacebar
		} 
        
    }

	public void TakeDamage(int amount)
	{
		Health -= amount;
	}

    void SetDirection(Direction targetDirection)
	{
		if (Attack == false) 
		{
			if (currentDirection == targetDirection)
				return;
			currentDirection = targetDirection;
			switch (currentDirection) 
			{
			case Direction.Up:
				transform.eulerAngles = new Vector3 (0, 0, 0);
				break;
			case Direction.Left:
				transform.eulerAngles = new Vector3 (0, 90, 0);
				break;
			case Direction.Right:
				transform.eulerAngles = new Vector3 (0, -90, 0);
				break;
			case Direction.Down:
				transform.eulerAngles = new Vector3 (0, 180, 0);
				break;
			}
		}
	}

}