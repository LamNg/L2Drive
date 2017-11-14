using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerLog : MonoBehaviour {

    public static int StartFirst;
    public static int ShopFirst;
    public static int CreditFirst;

    bool firstRun = true;

	// Use this for initialization
	void Start () {
        Debug.Log(StartFirst);
        Debug.Log(ShopFirst);
        Debug.Log(CreditFirst);
        Debug.Log(firstRun);

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
            SplashScreenFirstChoiceWrite();
            Debug.Log(firstRun);
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

    }



}
