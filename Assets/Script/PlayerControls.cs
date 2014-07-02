using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour 
{

	public KeyCode moveUp;
	public KeyCode moveDown;
	float speed = 10f;
	
	void Update () 
	{
		if(Input.GetKey(moveUp))
		{
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, speed);
		}
		else if(Input.GetKey(moveDown))
		{
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, -speed);
		}
		else
		{
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 0);
		}
        rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
	}
}