using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameTransition : MonoBehaviour {

    public string Level;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Application.LoadLevel(Level);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
