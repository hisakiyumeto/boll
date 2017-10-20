using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public int stageNo;

    public bool isBallMoving;

    public GameObject ballPrefab;
    public GameObject ball;
    public GameObject goButton;
    public GameObject retryButton;
    public GameObject clearText;
    public AudioClip clearSE;
    private AudioSource audioSource;
    
    


    // Use this for initialization
void Start () {

        audioSource = gameObject.GetComponent<AudioSource>();
        retryButton.SetActive(false);
        isBallMoving = false;
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    
    //GOボタン
    public void PushGoButton()
    {
        Rigidbody2D rd = ball.GetComponent<Rigidbody2D>();
        rd.isKinematic = false;
        retryButton.SetActive(true);
        goButton.SetActive(false);
        isBallMoving = true;
    }
    //リトライボタン
    public void PushRetryButton()
    {
        Destroy(ball);
        ball = (GameObject)Instantiate(ballPrefab);

        retryButton.SetActive(false);
        goButton.SetActive(true);
        isBallMoving = false;
    }
    public void PushBackButton()
    {
        GobackStageSelect();
    }
    void GobackStageSelect()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
    public void StageClear()
    {
        audioSource.PlayOneShot(clearSE);
        if (PlayerPrefs.GetInt("CLEAR", 0) < stageNo)
        {
            PlayerPrefs.SetInt("CLEAR", stageNo);
        }
        clearText.SetActive(true);
        retryButton.SetActive(false);
        Invoke("GoBackStageSelect", 3.0f);
    }

}
