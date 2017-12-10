using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class submitHighscore : MonoBehaviour {

    static bool NewHighScore;
    public InputField playerName;

    int currentScore;
    int scoreCheck;

    public GameObject SubmissionBar;
    public Button TalkToBoss;

    // Use this for initialization
    void Start () {

        currentScore = PlayerPrefs.GetInt("CurrentScore");
        scoreCheck = PlayerPrefs.GetInt("ScoreCheck");
        Debug.Log(PlayerPrefs.GetInt("CurrentScore") + " THIS IS THE CURRENT SCORE");
        //if it is a new highscore, prompt the popup screen

        if (scoreCheck == 1)
        {
            SubmissionBar.SetActive(true);
            TalkToBoss.interactable = false;
        }
        else
        {
            SubmissionBar.SetActive(false);
            TalkToBoss.interactable = true;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InputInitials()
    {
        GetComponent<Leaderboard>().CheckForHighScore(currentScore, playerName.text);
        SubmissionBar.SetActive(false);
        TalkToBoss.interactable = true;
    }
}
