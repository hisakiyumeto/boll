using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour {
    int x;

    private Vector3 initialPosition;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 4.0f + initialPosition.x, initialPosition.y, initialPosition.z);
    }
}
