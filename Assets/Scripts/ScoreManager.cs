using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    Dictionary<string, Dictionary<string, int>> playerScores;

    int changeCounter = 0;

    private void Start() {
        SetScore("Brandon", "score", 45535);
        SetScore("bob", "score", 23535);
        SetScore("AAAAAA", "score", 12535);
        SetScore("BBBBBB", "score", 40455);

        Debug.Log(GetScore("quill18", "kills"));

    }

    void Init(){

        if (playerScores != null)
            return;

        playerScores = new Dictionary<string, Dictionary<string, int>>();
    }

    public int GetScore(string username, string scoreType)
    {
        Init();
        if (playerScores.ContainsKey(username)== false)
        {
            //we have no score to record at all for this username
            return 0;
        }

        if (playerScores[username].ContainsKey(scoreType)== false)
        {
            return 0;
        }

        return playerScores[username][scoreType];

    }

    public void SetScore(string username, string scoreType, int value)
    {
        Init();

        changeCounter++;

        if (playerScores.ContainsKey(username) == false)
        {
            playerScores[username] = new Dictionary<string, int>();
        }

        playerScores[username][scoreType] = value;

    }

    public void ChangeScore (string username, string scoreType, int amount)
    {
        Init();
        int currScore = GetScore(username, scoreType);
        SetScore(username, scoreType, currScore + amount);
    }

    public string[] GetPlayerNames(string sortingScoreType)
    {
        Init();

        return playerScores.Keys.OrderByDescending(n => GetScore(n, sortingScoreType)).ToArray(); 
    }

    public int GetChangeCounter()
    {
        return changeCounter;
    }
}
