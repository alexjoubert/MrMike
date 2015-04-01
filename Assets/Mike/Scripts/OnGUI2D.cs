using UnityEngine;
using System.Collections;

public class OnGUI2D : MonoBehaviour {

	public static int Score = 0;
	public GameDataScript gameDataScript;

	// Initializations
	void Start () {
		//Initialize Score to 0.
		Score = 0;
	}

	void OnGUI(){
		GUI.Label (new Rect (10, 10, 100, 20), "Score: " + Score);	//Displays current score on to screen.
	}

	public void Update(){
		Score++;	//Score++ per frame
	}

	//Accessor Method for score
	public int getScore(){
		return Score;
	}
	

}
