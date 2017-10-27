using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaiten2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}    float direction = 80.0f;
        float speed = 1.0f;
        Vector2 v;
	  
	// Update is called once per frame
	void Update () {
    
      v.x = Mathf.Cos(Mathf.Deg2Rad * direction) * speed;
        v.y = Mathf.Sin(Mathf.Deg2Rad * direction) * speed;

        Rigidbody2D rd = GetComponent<Rigidbody2D>();
        rd.velocity = v;
    }  // 40度方向に5の速度で移動する
      
        
}
