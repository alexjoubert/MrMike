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
		if (!first) {
			UpdateLevel ();	//CurrentLevel++
			Debug.Log (gameDataScript.getAllLevelsComplete ());
			if (!gameDataScript.getAllLevelsComplete ()) {

				Application.LoadLevel ("LevelComplete");}


			//When All Levels Complete, return to Main Menu
			else {
				Debug.Log ("Should be here.");
				gameDataScript.setGameStart(false);
				Application.LoadLevel ("MainMenu");}
				} 

		else {
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
