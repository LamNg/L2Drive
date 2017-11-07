using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour {

    int goldAmount;
    int isFerrariSold;

    public Text goldAmountText;
    public Text ferrariPrice;

    public Button buyButton;

    //use this for initialization, get the proper amount of gold for the player
    void Start()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");

    }


    void Update()
    {
        goldAmountText.text = "Gold: " + goldAmount.ToString() + "$";
        isFerrariSold = PlayerPrefs.GetInt("IsFerrariSold");

        if (goldAmount >= 5 && isFerrariSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;
    } 

    //temp add money function to test
    public void addMoney()
    {
        goldAmount += 20;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
        Update();
    }

    //buy the ferrari + set it to sold
    public void buyFerrari()
    {
        goldAmount -= 10;
        PlayerPrefs.SetInt ("IsFerrariSold", 1);
        ferrariPrice.text = "Sold!";
        buyButton.gameObject.SetActive(false);

    }

    //save current money on shop exit
    public void exitShop()
    {
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
        SceneManager.LoadScene("Main Menu");
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
