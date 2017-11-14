using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

using System.Diagnostics;
using System.IO;

public class ViewModel : MonoBehaviour {

    Stopwatch stopwatch = new Stopwatch();

    void Start()
    {
        print("starting timer");
        stopwatch.Start();
    }

    //when start button is pressed
    public void buttonStartGame() {
        //change scene when pressed
        SceneManager.LoadScene("Intro");
        timeStamp();
    }

    public void buttonStorySelect()
    {
        string buttonName = this.name;
        SceneManager.LoadScene(buttonName);
        timeStamp();
    }

    public void buttonCorrectAnswer()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        SceneManager.LoadScene(buttonName);
        timeStamp();
    }

    public void buttonLose()
    {
        //change scene when pressed
        SceneManager.LoadScene("LosingScreen");
        timeStamp();
    }

    public void buttonLose2()
    {
        //change scene when pressed
        SceneManager.LoadScene("LosingScreen2");
        timeStamp();
    }

    public void buttonMain()
    {
        //change scene when pressed
        SceneManager.LoadScene("Main Menu");
        timeStamp();
    }

    public void buttonShop()
    {
        //change scene when pressed
        SceneManager.LoadScene("Shop");
        timeStamp();
    }

    public void buttonCredits()
    {
        //change scene when pressed
        SceneManager.LoadScene("Credits");
        timeStamp();
    }

    public void timeStamp()
    {
        string text = SceneManager.GetActiveScene().name + " took " + stopwatch.Elapsed + " seconds";
        //System.IO.File.WriteAllText(@"C:\Users\Russell\Documents\L2Drive\textfile.txt", text);
        //C:\Users\Russell\Documents\L2Drive
        TextWriter textWriter = new StreamWriter(@"textfile.txt", true);
        textWriter.WriteLine(text);
        textWriter.Close();
        print(text);
        stopwatch.Stop();
    }
}
