using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{



    //store stats
    public Text goldText;
    public static int goldAmount;
    int isFerrariSold;
    int isFerrariBlueSold;
    int isFerrariYellowSold;
    public GameObject ferrari;
    public GameObject ferrariBlue;
    public GameObject ferrariYellow;


    // Use this for initialization
    void Start()
    {

        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        isFerrariSold = PlayerPrefs.GetInt("IsFerrariSold");
        isFerrariBlueSold = PlayerPrefs.GetInt("IsFerrariBlueSold");
        isFerrariYellowSold = PlayerPrefs.GetInt("IsFerrariYellowSold");


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

 

}