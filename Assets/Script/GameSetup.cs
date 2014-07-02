﻿using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour 
{

	public Camera mainCam;
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;
	public Transform playerOne;
	public Transform playerTwo;
	Vector2 temp;
	
	void Start () 
	{
        topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        topWall.center = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        bottomWall.center = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

        leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        leftWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);

        rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        rightWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);


		temp = playerOne.position;
        temp.x = mainCam.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x;
		playerOne.position = temp;

		temp = playerTwo.position;
        temp.x = mainCam.ScreenToWorldPoint(new Vector3(Screen.width - 75f, 0f, 0f)).x;
		playerTwo.position = temp;
	}
}