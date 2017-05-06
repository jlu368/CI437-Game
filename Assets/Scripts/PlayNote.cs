using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote : MonoBehaviour {

    public AudioSource audio;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        audio.Play();
    }

}
