using UnityEngine;
using System.Collections;

public class WallSide : MonoBehaviour {
	
	void OnTriggerEnter2D (Collider2D hitInfo) 
	{
		if (hitInfo.name.Equals("Ball"))
		{
            audio.Play();
            GameManage.ScoreUpdate(transform.name);
            hitInfo.gameObject.SendMessage("ResetBall");
		}
	}
}
