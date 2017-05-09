using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(gameObject.name=="C Note(Clone)") {
			GetComponent<Rigidbody>().velocity = new Vector3(0,-1,0);
		}
		if(gameObject.name=="D Note(Clone)") {
			GetComponent<Rigidbody>().velocity = new Vector3(0,-1,0);
		}
		if(gameObject.name=="E Note(Clone)") {
			GetComponent<Rigidbody>().velocity = new Vector3(0,-1,0);
		}
		if(gameObject.name=="F Note(Clone)") {
			GetComponent<Rigidbody>().velocity = new Vector3(0,-1,0);
		}
		if(gameObject.name=="G Note(Clone)") {
			GetComponent<Rigidbody>().velocity = new Vector3(0,-1,0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if((SongControl.destroyC=="y") && (gameObject.name=="C Note(Clone)")) {
			Destroy (gameObject);
		}
		if((SongControl.destroyD=="y") && (gameObject.name=="D Note(Clone)")) {
			Destroy (gameObject);
		}
		if((SongControl.destroyE=="y") && (gameObject.name=="E Note(Clone)")) {
			Destroy (gameObject);
		}
		if((SongControl.destroyF=="y") && (gameObject.name=="F Note(Clone)")) {
			Destroy (gameObject);
		}
		if((SongControl.destroyG=="y") && (gameObject.name=="G Note(Clone)")) {
			Destroy (gameObject);
		}
	}
}
