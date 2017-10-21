using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using UnityEngine;

public class SceneButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadScene()
    {
        string buttonName = this.name;
        //string buttonNumber = Regex.Replace(buttonName, "[^0-9]", "");
        //SceneManager.LoadScene("Scene" + buttonNumber);
        SceneManager.LoadScene("" + buttonName);
        // Debug.Log(buttonName + buttonNumber);
    }
}
