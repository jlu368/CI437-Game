using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote : MonoBehaviour {

    public bool piano;

	public string name; //name of key, like C or D
    private AudioSource audio;
    private bool play = true;

	private SimonSays theSimon; //manages Simon Says, use for calling KeyPressed

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
		theSimon = FindObjectOfType<SimonSays> ();
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

    void OnMouseDown()
    {
        if(piano)
            audio.Play();
    }

	void OnMouseUp()
	{
		theSimon.KeyPressed (name);
	}

}
