using UnityEngine;
using System.Collections;

public class GameManage : MonoBehaviour 
{

    static int POneScore = 0, PTwoScore = 0;
	public GUISkin uiSkin;
    Transform ballNaja;

    void Start()
    {
        ballNaja = GameObject.FindGameObjectWithTag("Ball").transform;
    }

	static public void ScoreUpdate (string wallName) 
	{
		if (wallName.Equals("rightWall"))
		{
			POneScore += 1;
		}
		else
		{
			PTwoScore += 1;
		}
        Debug.Log(POneScore + " : " + PTwoScore);
	}

	void OnGUI ()
	{
		GUI.skin = uiSkin;
        GUI.Label(new Rect(Screen.width / 2 - 100 - 20, 20, 100, 100), POneScore + "");
        GUI.Label(new Rect(Screen.width / 2 + 100, 20, 100, 100), PTwoScore + "");

        if (GUI.Button(new Rect((Screen.width / 2) - (121 / 2), 15, 121, 53), "Reset"))
        {
            POneScore = 0;
            PTwoScore = 0;

            ballNaja.gameObject.SendMessage("ResetBall");
        }
	}
}