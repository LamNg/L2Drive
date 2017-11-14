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

    public void buttonRouteSelect()
    {
        SceneManager.LoadScene(this.name);
        timeStamp();
    }

    public void buttonStorySelect()
    {
        //string buttonName = this.name;
        SceneManager.LoadScene(this.name);
        timeStamp();
        answerStamp("Correct Answer");
    }

    public void buttonLose()
    {
        //change scene when pressed
        SceneManager.LoadScene("LosingScreen");
        timeStamp();
        answerStamp(this.name);
    }

    public void buttonLose2()
    {
        //change scene when pressed
        SceneManager.LoadScene("LosingScreen2");
        timeStamp();
        answerStamp(this.name);
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
        TextWriter textWriter = new StreamWriter(@"textfile.txt", true);
        textWriter.WriteLine(text);
        textWriter.Close();
        print(text);
        stopwatch.Stop();
    }

    public void answerStamp(string button)
    {
        TextWriter textWriter = new StreamWriter(@"textfile.txt", true);
        textWriter.WriteLine("User chose: " + button);
        textWriter.Close();
    }

}
