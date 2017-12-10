using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public int currentCar;

    public GameObject currentCarSprite;
    public Sprite Car0;
    public Sprite Car1;
    public Sprite Car2;



    // Use this for initialization
    void Start()
    {

        currentCar = PlayerPrefs.GetInt("CurrentCar");
        Debug.Log(currentCar + " is the current car");

        setCarSprite();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void setCarSprite()
    {
        switch (currentCar)
        {
            case 0:
                currentCarSprite.GetComponent<Image>().sprite = Car0;
                break;
            case 1:
                currentCarSprite.GetComponent<Image>().sprite = Car1;
                break;
            case 2:
                currentCarSprite.GetComponent<Image>().sprite = Car2;            
                break;
        }
    }


}