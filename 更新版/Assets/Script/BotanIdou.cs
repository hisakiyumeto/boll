using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BotanIdou : MonoBehaviour {

    
    // Use this for initialization
    void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {

    }
    public void StageSelectScene()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
    public void StageSelectScene2()
    {
        SceneManager.LoadScene("StageSelectScene2");
    }
    public void StageSelectScene3()
    {
        SceneManager.LoadScene("Setumei");
    }
    public void StageSelectScene4()
    {
        SceneManager.LoadScene("TitleStartScene");
    }
    public void StageSelectScene5()
    {
        SceneManager.LoadScene("Setumei2");
    }
}
