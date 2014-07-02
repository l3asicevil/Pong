using UnityEngine;
using System.Collections;

public class BallControls : MonoBehaviour 
{

    public float ballSpeed = 100;

	IEnumerator Start () 
	{
        yield return new WaitForSeconds(3);
		BallStart();
	}

    void Update()
    {
        float xVel = rigidbody2D.velocity.x;
        if (xVel < 18 && xVel > -18 && xVel != 0)
        {
            if (xVel > 0)
            {
                rigidbody2D.velocity = new Vector2(20, rigidbody2D.velocity.y);
            }
            else
            {
                rigidbody2D.velocity = new Vector2(-20, rigidbody2D.velocity.y);
            }
        }
    }

	void OnCollisionEnter2D (Collision2D colInfo) 
	{ 
		if (colInfo.collider.tag == "Player")
		{
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, ((rigidbody2D.velocity.y / 3) + (colInfo.collider.rigidbody2D.velocity.y / 2)));
            audio.pitch = Random.Range(0.8f, 1.2f);
            audio.Play();
		}
	}

	IEnumerator ResetBall ()
	{
        rigidbody2D.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);

        yield return new WaitForSeconds(2);
        BallStart();
	}

	void BallStart ()
	{
        int random = Random.Range(0, 2);
		if (random <= 0.9)
		{
            rigidbody2D.AddForce(new Vector2(ballSpeed, 0));
		}
		else
		{
            rigidbody2D.AddForce(new Vector2(-ballSpeed, 0));
		}
	}
}
