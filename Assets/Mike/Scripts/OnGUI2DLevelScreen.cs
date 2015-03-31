using UnityEngine;
using System.Collections;

public class OnGUI2DLevelScreen : MonoBehaviour {

	static public int Score = 0;

	// Initializations
	void Start () {
		//Initialize Score to 0.
		Score = 0;
	
	}

	void OnGUI(){
		//Display Score on Upper-Left Corner of Game Screen
		GUI.Label (new Rect (-250, -16, 200, 30), "Score: " + Score);

	}

	public void IncScore(){
		//Increase Score per frame that player is not dead.
		Score += 1;
	}
	

}
