using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Leaderboard : MonoBehaviour {

    public Text[] highScores;
    public Text[] highScoreNamesText;
    int [] highScoreValues;
    string[] highScoreNames;



	// Use this for initialization
	void Start () {
        highScoreValues = new int[highScores.Length];
        highScoreNames = new string[highScoreNamesText.Length];

        for (int x = 0; x < highScores.Length; x++)
        {
            highScoreValues[x] = PlayerPrefs.GetInt("highScoreValues" + x);
            highScoreNames[x] = PlayerPrefs.GetString("highScoreNames" + x);

        }
        DrawScores();

    }

    void SaveScores()
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            PlayerPrefs.SetInt("highScoreValues" + x,highScoreValues [x]);
            PlayerPrefs.SetString("highScoreNames" + x, highScoreNames[x]);
        }
    }

    public void CheckForHighScore(int value, string username)
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            if (value > highScoreValues[x])
            {
                for (int y = highScores.Length-1; y > x; y--)
                {
                    highScoreValues[y] = highScoreValues[y - 1];
                    highScoreNames[y] = highScoreNames[y - 1];
                }
                highScoreValues[x] = value;
                highScoreNames[x] = username;
                DrawScores();
                SaveScores();
                break;
            }
        }
    }

    public bool checkReachtop10(int score)
    {
        //prompt for name submission if in top 10 leaderboard
        if (score > highScoreValues[9])
        {
            return true;
        }
        return false;
    }



    void DrawScores()
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            highScores[x].text = highScoreValues[x].ToString();
            highScoreNamesText[x].text = highScoreNames[x];

        }
    }

    bool Top5Check()
    {
        return false;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
