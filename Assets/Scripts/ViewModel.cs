using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ViewModel : MonoBehaviour {

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
        string buttonName = this.name;
        SceneManager.LoadScene(buttonName);
    }

    public void buttonLose()
    {
        //change scene when pressed
        SceneManager.LoadScene("End1");
    }

    public void buttonMain()
    {
        //change scene when pressed
        SceneManager.LoadScene("Main Menu");
    }
}
