using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerScoreList : MonoBehaviour {

    public GameObject playerScoreEntryPrefab;

    ScoreManager scoreManager;

    int lastChangeCounter;

	// Use this for initialization
	void Start () {

        scoreManager = GameObject.FindObjectOfType<ScoreManager>();

        lastChangeCounter = scoreManager.GetChangeCounter();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreManager == null)
        {
            Debug.LogError("Forgot to add score manager component to a game object!");
            return;
        }

        if(scoreManager.GetChangeCounter() == lastChangeCounter)
        {
            //no change since last update!
            return;
        }
        lastChangeCounter = scoreManager.GetChangeCounter();

        while (this.transform.childCount > 0)
        {
            Transform c = this.transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }

        string[] names = scoreManager.GetPlayerNames("score");

        foreach (string name in names)
        {
            GameObject go = Instantiate(playerScoreEntryPrefab);
            go.transform.SetParent(this.transform);
            go.transform.Find("Username").GetComponent<Text>().text = name;
            go.transform.Find("Score").GetComponent<Text>().text = scoreManager.GetScore(name,"score").ToString();

        }
    }
}
