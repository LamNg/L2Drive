using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerLog : MonoBehaviour {

    public static int StartFirst;
    public static int ShopFirst;
    public static int CreditsFirst;

    bool firstRun = true;

    // Use this for initialization

	void Start () {
        //StartFirst = PlayerPrefs.GetInt("StartFirst");
        //ShopFirst = PlayerPrefs.GetInt("ShopFirst");
        //CreditsFirst = PlayerPrefs.GetInt("CreditsFirst");
        print("current value of Bool: " + firstRun);
    }
    
    public void countChoice(string Button)
    {
        if (firstRun)
        {
            if (Button == "Start")
            {
                StartFirst += 1;
                //PlayerPrefs.SetInt("StartFirst", StartFirst);
            }
            else if (Button == "Shop")
            {
                ShopFirst += 1;
                //PlayerPrefs.SetInt("ShopFirst", ShopFirst);
            }
            else if (Button == "Credits")
            {
                CreditsFirst += 1;
                //PlayerPrefs.SetInt("CreditsFirst", CreditsFirst);
            }
            SplashScreenFirstChoiceWrite();
            
        }
        firstRun = false;
        Debug.Log(firstRun);
    }

    public void SplashScreenFirstChoiceWrite()
    {
        string text = "Player Selected First: \nStart: " + StartFirst+ " \nShop: " + ShopFirst + "\nCredits: " + CreditsFirst;
        TextWriter textWriter = new StreamWriter(@"SplashScreenDecision.txt", true);
        textWriter.WriteLine(text);
        textWriter.Close();
    }




}
