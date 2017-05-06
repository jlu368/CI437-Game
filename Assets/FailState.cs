using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailState : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D col){
        Application.LoadLevel("Game Over");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
