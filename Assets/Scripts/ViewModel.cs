using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ViewModel : MonoBehaviour {

    string hi = "Hi";

    //when start button is pressed
    public void buttonStartGame() {
        //change scene when pressed
        SceneManager.LoadScene("Intro");
    }

    public void buttonStorySelect()
    {
        string buttonName = this.name;
        SceneManager.LoadScene(buttonName);
    }

    public void buttonCorrectAnswer()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        SceneManager.LoadScene(buttonName);
    }

    public void buttonLose()
    {
        //change scene when pressed
        SceneManager.LoadScene("LosingScreen");
    }

    public void buttonLose2()
    {
        //change scene when pressed
        SceneManager.LoadScene("LosingScreen2");
    }

    public void buttonMain()
    {
        //change scene when pressed
        SceneManager.LoadScene("Main Menu");
    }

    public void buttonShop()
    {
        //change scene when pressed
        SceneManager.LoadScene("Shop");
    }

    public void buttonCredits()
    {
        //change scene when pressed
        SceneManager.LoadScene("Credits");
    }


}
