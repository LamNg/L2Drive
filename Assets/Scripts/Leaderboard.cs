﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Leaderboard : MonoBehaviour {

    public Text[] highScores;
    int [] highScoreValues;
    string[] highScoreNames;



	// Use this for initialization
	void Start () {
        highScoreValues = new int[highScores.Length];
        highScoreNames = new string[highScores.Length];

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
                DrawScores();
                SaveScores();
                break;
            }
        }
    }

    void DrawScores()
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            highScores[x].text = highScoreNames[x] + " \t \t \t \t \t \t \t \t \t" + highScoreValues[x].ToString();

        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}