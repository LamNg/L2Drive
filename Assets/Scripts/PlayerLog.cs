using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerLog : MonoBehaviour {

    public int StartFirst;
    public int ShopFirst;
    public int CreditFirst;

    bool firstRun;

    public int value = 5;
	// Use this for initialization
	void Start () {
        bool firstRun = true;
        Debug.Log(value);


    }

    public void countChoice()
    {
        if (firstRun)
        {
            if (this.name == "Start")
            {
                StartFirst += 1;
            }
            else if (this.name == "Shop")
            {
                ShopFirst += 1;
            }
            else if (this.name == "Credits")
            {
                CreditFirst += 1;
            }
            firstRun = false;
        }

    }

    public void SplashScreenFirstChoiceWrite()
    {
        string text = "Player Selected First: \nStart: " + StartFirst+ " \nShop: " + ShopFirst + "\nCredits: " + CreditFirst;
        TextWriter textWriter = new StreamWriter(@"SplashScreenDecision.txt", true);
        textWriter.WriteLine(text);
        textWriter.Close();
        print(text);
    }

    public void Update()
    {
        Debug.Log(StartFirst);
        Debug.Log(ShopFirst);
        Debug.Log(CreditFirst);
    }



}
