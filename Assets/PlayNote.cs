using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote : MonoBehaviour {

    private AudioSource audio;
    private bool play = true;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (play)
        {
            audio.Play();
            play = false;
        }
        else
            play = true;
    }

}
