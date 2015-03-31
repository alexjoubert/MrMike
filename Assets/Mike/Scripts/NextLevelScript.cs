using UnityEngine;
using System.Collections;

public class NextLevelScript : MonoBehaviour {

	public GameDataScript gameDataScript;
	public GameStatus gameStatus;
	public bool first;					//Temporary fix to bug that causes collision function to run twice.

	void Start(){
		first = true;
	}

	//When player reaches end of level, load next level
	void OnTriggerEnter2D(Collider2D other){
		PlayerPrefs.SetInt ("CurrentScore", gameDataScript.getCurrentScore ());
		if (!first) {
			UpdateLevel ();	//CurrentLevel++

			//When All Levels Complete, return to Main Menu
			if (gameDataScript.getAllLevelsComplete ()) {

				gameDataScript.setGameStart (false);
			}

			Application.LoadLevel ("LevelComplete");				
		} else {
			first = false;
			}
	}

	void UpdateLevel(){
		gameDataScript.setCurrentLevel (gameDataScript.getCurrentLevel () + 1);

		if(gameDataScript.getCurrentLevel()==gameDataScript.getFinalLevel()){
			gameDataScript.setAllLevelsComplete(true);
			Debug.Log ("After update: " + gameDataScript.getAllLevelsComplete());
		}

	}

}
