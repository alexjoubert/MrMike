using UnityEngine;
using System.Collections;

public class OnGUI2DLevelScreen : MonoBehaviour {

	static public int Score = 0;
	public GameDataScript gameDataScript;

	// Initializations
	void Start () {
		//Initialize Score to 0.
		Score = PlayerPrefs.GetInt ("CurrentScore");
	
	}

	void OnGUI(){
		Debug.Log ("OnGUI2D: " + Score);
		//Display Score on Upper-Left Corner of Game Screen
		GUI.Label (new Rect (550, 307, 100, 20), "" + Score);

	}


}
