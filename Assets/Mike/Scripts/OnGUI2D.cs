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
			//Display Score on Upper-Left Corner of Game Screen
			GUI.Label (new Rect (10, 10, 100, 20), "Score: " + Score);
			//Debug.Log (Score);
	}

	public void Update(){
		Score++;
	}

	public int getScore(){
		return Score;
	}

}
