using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonSays : MonoBehaviour {
	public string Level; //level to go to once complete Simon Says

	private string[] odeToJoyNotes; //stores notes for Ode to Joy in string format
	private int numNotes; //how many notes to display
	private int currNote; //index for which note currently at

	private string[] currNotesToPlay; //stores which notes to currently play
	private int currNotesCurrIndex; //stores which index in array current note to play in sequence is

	public Text playNotesText; //text for what to display for Simon Says for player to play
	public Text correctnessText; //text for what to display for Simon Says for player to play

	// Use this for initialization
	void Start () {
		odeToJoyNotes=new string[15];
		odeToJoyNotes[0]="E";
		odeToJoyNotes[1]="E";
		odeToJoyNotes[2]="F";
		odeToJoyNotes[3]="G";
		odeToJoyNotes[4]="G";
		odeToJoyNotes[5]="F";
		odeToJoyNotes[6]="E";
		odeToJoyNotes[7]="D";
		odeToJoyNotes[8]="C";
		odeToJoyNotes[9]="C";
		odeToJoyNotes[10]="D";
		odeToJoyNotes[11]="E";
		odeToJoyNotes[12]="E";
		odeToJoyNotes[13]="D";
		odeToJoyNotes[14]="D";

		numNotes = 1;

		currNote = 0;

		currNotesToPlay=new string[numNotes];
		for (int i = 0; i < numNotes; i++) {
			currNotesToPlay [i] = odeToJoyNotes [currNote + i];
		}

		currNotesCurrIndex = 0;

		playNotesText.text = "Play these notes: ";

		for (int i = 0; i < currNotesToPlay.Length; i++) {
			if(i<currNotesToPlay.Length-1) {
				playNotesText.text += currNotesToPlay [i] + " "; //include space for next note
			} else {
				playNotesText.text += currNotesToPlay[i]; //no more following space because last note
			}
		}

		correctnessText.text = "";
	}

	// Update is called once per frame
	void Update () {
		if(currNotesCurrIndex>=currNotesToPlay.Length) { //reached end of Simon Says for this sequence
			if (numNotes == 5) {
				playNotesText.text = "Congratulations!"; //reached end of entire song
				Application.LoadLevel(Level);
			} else { //update for next sequence
				currNote=currNote+numNotes; //increment to next set of notes
				numNotes++; //increment to play more notes

				//fill up array of notes to play again
				currNotesToPlay=new string[numNotes];
				for (int i = 0; i < numNotes; i++) {
					currNotesToPlay [i] = odeToJoyNotes [currNote + i];
				}
				currNotesCurrIndex = 0;

				playNotesText.text = "Play these notes: ";

				for (int i = 0; i < currNotesToPlay.Length; i++) {
					if(i<currNotesToPlay.Length-1) {
						playNotesText.text += currNotesToPlay [i] + " "; //include space for next note
					} else {
						playNotesText.text += currNotesToPlay[i]; //no more following space because last note
					}
				}
			}
		}
	}

	public void KeyPressed(string whichKey) {
		if(currNotesToPlay[currNotesCurrIndex].Equals(whichKey)) {
			//Debug.Log ("Correct: "+whichKey);
			correctnessText.text="Correct!";
			currNotesCurrIndex++;
			//Debug.Log (currNotesCurrIndex+","+currNotesToPlay.Length);
		} else {
			//Debug.Log ("Wrong: "+whichKey);
			correctnessText.text="Try Again!";
		}
	}
}