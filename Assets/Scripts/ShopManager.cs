using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{

    int goldAmount;
    int isFerrariSold;
    int isFerrariBlueSold;
    int isFerrariYellowSold;

    public Text goldAmountText;
    public Text ferrariPrice;
    public Text ferrariBluePrice;
    public Text ferrariYellowPrice;

    public Button buyButton;
    public Button buyButtonBlue;
    public Button buyButtonYellow;


    //use this for initialization, get the proper amount of gold for the player
    void Start()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");

    }


    void Update()
    {
        goldAmountText.text = "Gold: " + goldAmount.ToString() + "$";
        isFerrariSold = PlayerPrefs.GetInt("IsFerrariSold");
        isFerrariBlueSold = PlayerPrefs.GetInt("IsFerrariBlueSold");
        isFerrariYellowSold = PlayerPrefs.GetInt("IsFerrariYellowSold");


        if (goldAmount >= 10 && isFerrariSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;
        //for blue ferrari
        if (goldAmount >= 10 && isFerrariBlueSold == 0)
            buyButtonBlue.interactable = true;
        else
            buyButtonBlue.interactable = false;
        // for yellow ferrari
        if (goldAmount >= 10 && isFerrariYellowSold == 0)
            buyButtonYellow.interactable = true;
        else
            buyButtonYellow.interactable = false;
    }



    //buy the ferrari + set it to sold
    public void buyFerrari()
    {
        goldAmount -= 10;
        PlayerPrefs.SetInt("IsFerrariSold", 1);
        ferrariPrice.text = "Sold!";
        buyButton.gameObject.SetActive(false);

    }

    public void buyFerrariBlue()
    {
        goldAmount -= 10;
        PlayerPrefs.SetInt("IsFerrariBlueSold", 1);
        ferrariBluePrice.text = "Sold!";
        buyButtonBlue.gameObject.SetActive(false);

    }

    public void buyFerrariYellow()
    {
        goldAmount -= 10;
        PlayerPrefs.SetInt("IsFerrariYellowSold", 1);
        ferrariYellowPrice.text = "Sold!";
        buyButtonYellow.gameObject.SetActive(false);

    }

    //save current money on shop exit
    public void exitShop()
    {
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
        SceneManager.LoadScene("Main Menu");
    }

    //temp add money function to test
    public void addMoney()
    {
        goldAmount += 20;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
        Update();
    }

    //reset player prefs to zero
    public void resetPlayerPrefs()
    {
        goldAmount = 0;
        buyButton.gameObject.SetActive(true);
        ferrariPrice.text = "Price: 10 gold";
        PlayerPrefs.DeleteAll();
    }


}
