using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //ボールの衝突時
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Collistion");
        if (coll.gameObject.tag == "OutArea")
        {
            //「アウトエリア」に衝突
            //ゲームマネージャーを取得
            GameObject gameManager = GameObject.Find("GameManager");
            //リトライ
            gameManager.GetComponent<GameManager>().PushRetryButton();
        }
    }
    void OnTriggerEnter2D(Collider2D other )
    {
        if (other.gameObject.tag == "ClearArea")
        {
            //クリアーエリアに入った
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager>().StageClear();
        }
    }
}
