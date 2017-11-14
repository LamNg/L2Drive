using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerLog : MonoBehaviour {

    public static int StartFirst;
    public static int ShopFirst;
    public static int CreditsFirst;

    bool firstRun = false;

	// Use this for initialization
	void Start () {
        StartFirst = PlayerPrefs.GetInt("StartFirst");
        ShopFirst = PlayerPrefs.GetInt("ShopFirst");
        CreditsFirst = PlayerPrefs.GetInt("CreditsFirst");
    }
    
    void Awake()
    {
        firstRun = true;
    }

    public void countChoice(string Button)
    {
        if (firstRun)
        {
            if (Button == "Start")
            {
                StartFirst += 1;
                PlayerPrefs.SetInt("StartFirst", StartFirst);
            }
            else if (Button == "Shop")
            {
                ShopFirst += 1;
                PlayerPrefs.SetInt("ShopFirst", ShopFirst);
            }
            else if (Button == "Credits")
            {
                CreditsFirst += 1;
                PlayerPrefs.SetInt("CreditsFirst", CreditsFirst);
            }
            firstRun = false;
            SplashScreenFirstChoiceWrite();
            Debug.Log(firstRun);
        }

    }

    public void SplashScreenFirstChoiceWrite()
    {
        string text = "Player Selected First: \nStart: " + StartFirst+ " \nShop: " + ShopFirst + "\nCredits: " + CreditsFirst;
        TextWriter textWriter = new StreamWriter(@"SplashScreenDecision.txt", false);
        textWriter.WriteLine(text);
        textWriter.Close();
    }




}
