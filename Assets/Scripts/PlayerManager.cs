﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerManager : MonoBehaviour {

    //player stats
    static DateTime startTime;
    static DateTime endTime;
    
    //Stopwatch GameSessionstopwatch = new Stopwatch();
    // Use this for initialization

    void Start()
    {

    }


    public void GameStart()
    {

        print("starting Points timer");
        startTime = System.DateTime.UtcNow;
    }

    public void GameLose()
    {
        
    }

    public void GameWin()
    {

        endTime = System.DateTime.UtcNow;
        TimeSpan diff = endTime - startTime;
        int diffSeconds = diff.Seconds;
        print(diffSeconds + " seconds");
        print(ScoreCalculation(diffSeconds));


    }

    int ScoreCalculation(int timeInSeconds)
    {
        int baseAmount = 50000;
        int score = baseAmount - (timeInSeconds * 10);
        if (score < 0) //if total score ends up below 0
        {
            score = 0;
        }
        return score;
    }

}