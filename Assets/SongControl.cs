using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongControl : MonoBehaviour {

	public Transform CNote;
	public Transform DNote;
	public Transform ENote;
	public Transform FNote;
	public Transform GNote;

	public float songlength=0;

	//for keyboard binding and controls
	public KeyCode keyA;
	public KeyCode keyS;
	public KeyCode keyD;
	public KeyCode keyF;
	public KeyCode keyG;

	public static string destroyC = "n";
	public static string destroyD = "n";
	public static string destroyE = "n";
	public static string destroyF = "n";
	public static string destroyG = "n";

	void FixedUpdate() {
		songlength += Time.deltaTime;

		if ((songlength >= 0.1) && (songlength <= 0.125)) {
			Instantiate (ENote, ENote.position, ENote.rotation);
		}
		if ((songlength >= 1) && (songlength <= 1.025)) {
			Instantiate (ENote, ENote.position, ENote.rotation);
		}
		if ((songlength >= 2) && (songlength <= 2.025)) {
			Instantiate (FNote, FNote.position, FNote.rotation);
		}
		if ((songlength >= 3) && (songlength <= 3.025)) {
			Instantiate (GNote, GNote.position, GNote.rotation);
		}
		if ((songlength >= 4) && (songlength <= 4.025)) {
			Instantiate (GNote, GNote.position, GNote.rotation);
		}
		if ((songlength >= 5) && (songlength <= 5.025)) {
			Instantiate (FNote, FNote.position, FNote.rotation);
		}
		if ((songlength >= 6) && (songlength <= 6.025)) {
			Instantiate (ENote, ENote.position, ENote.rotation);
		}
		if ((songlength >= 7) && (songlength <= 7.025)) {
			Instantiate (DNote, DNote.position, DNote.rotation);
		}
		if ((songlength >= 8) && (songlength <= 8.025)) {
			Instantiate (CNote, CNote.position, CNote.rotation);
		}
		if ((songlength >= 9) && (songlength <= 9.025)) {
			Instantiate (CNote, CNote.position, CNote.rotation);
		}
		if ((songlength >= 10) && (songlength <= 10.025)) {
			Instantiate (DNote, DNote.position, DNote.rotation);
		}
		if ((songlength >= 11) && (songlength <= 11.025)) {
			Instantiate (ENote, ENote.position, ENote.rotation);
		}
		if ((songlength >= 12) && (songlength <= 12.025)) {
			Instantiate (ENote, ENote.position, ENote.rotation);
		}
		if ((songlength >= 13) && (songlength <= 13.025)) {
			Instantiate (DNote, DNote.position, DNote.rotation);
		}
		if ((songlength >= 14) && (songlength <= 14.025)) {
			Instantiate (DNote, DNote.position, DNote.rotation);
		}
	}

	void OnTriggerStay(Collider other) {
		if((Input.GetKeyDown(keyA)) && (other.gameObject.name=="C Note(Clone)")) {
			destroyC = "y";
		}
		if((Input.GetKeyDown(keyS)) && (other.gameObject.name=="D Note(Clone)")) {
			destroyD = "y";
		}
		if((Input.GetKeyDown(keyD)) && (other.gameObject.name=="E Note(Clone)")) {
			destroyE = "y";
		}
		if((Input.GetKeyDown(keyF)) && (other.gameObject.name=="F Note(Clone)")) {
			destroyF = "y";
		}
		if((Input.GetKeyDown(keyG)) && (other.gameObject.name=="G Note(Clone)")) {
			destroyG = "y";
		}
	}
}