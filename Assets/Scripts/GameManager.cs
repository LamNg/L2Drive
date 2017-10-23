﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public Text goldText;
    public static int goldAmount;
    int isFerrariSold;
    public GameObject ferrari;


    // Use this for initialization
    void Start()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        //goldAmount = 60;
        isFerrariSold = PlayerPrefs.GetInt("IsFerrariSold");

        //if (isFerrariSold == 1)
        //    ferrari.SetActive(true);
        //else
        //    ferrari.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = "Gold: " + goldAmount.ToString();
    }


    //add gold for testing
    //public void AddMoney()
    //{
    //    goldAmount += 5;
   //     Update();
   // }


    //set player gold back to 0 for testing
    //public void resetPlayerPrefs()
    //{
    //   goldAmount = 0;
    //    PlayerPrefs.DeleteAll();
    //}
}