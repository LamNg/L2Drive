using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    //checking if car is bought or not + current gold
    int goldAmount;
    int isFerrariSold;
    int isFerrariBlueSold;
    int isFerrariYellowSold;

    public Text goldAmountText;
    //public Text ferrariPrice;
    public Text ferrariBluePrice;
    public Text ferrariYellowPrice;

    //public Button buyButton;
    public Button buyButtonBlue;
    public Button buyButtonYellow;

    //checking which car is being used
    public int currentCar;

    public Button useButton;
    public Button useButtonBlue;
    public Button useButtonYellow;


    //use this for initialization, get the proper amount of gold for the player
    void Start()
    {

        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        isFerrariSold = 1; //Default red ferrari, is always given to player
        isFerrariBlueSold = PlayerPrefs.GetInt("IsFerrariBlueSold");
        isFerrariYellowSold = PlayerPrefs.GetInt("IsFerrariYellowSold");

        //remember current gold amount
        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        //remember current car in use
        currentCar = PlayerPrefs.GetInt("CurrentCar");

        //setting sold sign if already bought before entering shop
        if (PlayerPrefs.GetInt("IsFerrariBlueSold") == 1)
        {
            ferrariBluePrice.text = "Sold!";
        }
        else
        {
            useButtonBlue.interactable = false;
        }

        if (PlayerPrefs.GetInt("IsFerrariYellowSold") == 1)
        {
            ferrariYellowPrice.text = "Sold!";
        }
        else
        {
            useButtonYellow.interactable = false;
        }

        //setting use car buttons when entering shop
        switch (PlayerPrefs.GetInt("CurrentCar"))
        {
            case 0:
                useFerrari();
                break;
            case 1:
                useFerrariBlue();
                break;
            case 2:
                useFerrariYellow();
                break;
        }


    }


    void Update()
    {
        goldAmountText.text = "Gold: " + goldAmount.ToString();
        isFerrariSold = PlayerPrefs.GetInt("IsFerrariSold");
        isFerrariBlueSold = PlayerPrefs.GetInt("IsFerrariBlueSold");
        isFerrariYellowSold = PlayerPrefs.GetInt("IsFerrariYellowSold");

       /* 
        if (goldAmount >= 10 && isFerrariSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;
            */        
        
        //setting button availability based on gold amount

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
    /*
    public void buyFerrari()
    {
        goldAmount -= 10;
        PlayerPrefs.SetInt("IsFerrariSold", 1);
        ferrariPrice.text = "Sold!";
        buyButton.interactable = false;
        //allowing user to use car
        useButton.interactable = true;

    }
    */
    public void buyFerrariBlue()
    {
        goldAmount -= 10;
        PlayerPrefs.SetInt("IsFerrariBlueSold", 1);
        ferrariBluePrice.text = "Sold!";
        buyButtonBlue.interactable = false;
        //allowing user to use car
        useButtonBlue.interactable = true;

    }

    public void buyFerrariYellow()
    {
        goldAmount -= 10;
        PlayerPrefs.SetInt("IsFerrariYellowSold", 1);
        ferrariYellowPrice.text = "Sold!";
        buyButtonYellow.interactable = false;
        //allowing user to use car
        useButtonYellow.interactable = true;

    }


    //USING CAR -> 0 = red ferrari, 1 = blue ferrari, 2 = yellow ferrari
    //let user know they which car they are currently using
    public void useFerrari()
    {
        PlayerPrefs.SetInt("CurrentCar",0);
        useButton.GetComponentInChildren<Text>().text = "Using";
        useButton.interactable = false;
        //if another car is being used at the moment
        if (isFerrariBlueSold == 1 && useButtonBlue.interactable == false)
        {
            useButtonBlue.interactable = true;
            useButtonBlue.GetComponentInChildren<Text>().text = "Use";
        }
        if (isFerrariYellowSold == 1 && useButtonYellow.interactable == false)
        {
            useButtonYellow.interactable = true;
            useButtonYellow.GetComponentInChildren<Text>().text = "Use";
        }
    }
    public void useFerrariBlue()
    {
        PlayerPrefs.SetInt("CurrentCar", 1);
        useButtonBlue.GetComponentInChildren<Text>().text = "Using";
        useButtonBlue.interactable = false;
        if ( useButton.interactable == false)
        {
            useButton.interactable = true;
            useButton.GetComponentInChildren<Text>().text = "Use";
        }
        if (isFerrariYellowSold == 1 && useButtonYellow.interactable == false)
        {
            useButtonYellow.interactable = true;
            useButtonYellow.GetComponentInChildren<Text>().text = "Use";
        }
    }
    public void useFerrariYellow()
    {
        PlayerPrefs.SetInt("CurrentCar", 2);
        useButtonYellow.GetComponentInChildren<Text>().text = "Using";
        useButtonYellow.interactable = false;
        if (isFerrariBlueSold == 1 && useButtonBlue.interactable == false)
        {
            useButtonBlue.interactable = true;
            useButtonBlue.GetComponentInChildren<Text>().text = "Use";
        }
        if (useButton.interactable == false)
        {
            useButton.interactable = true;
            useButton.GetComponentInChildren<Text>().text = "Use";
        }

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

        PlayerPrefs.DeleteAll();
    }


}
