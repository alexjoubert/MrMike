using UnityEngine;
using System.Collections;

public class GameDataScript : MonoBehaviour {

	//Initializations
	static public bool AllLevelsComplete;
	static int StartLevel = 0;
	static int CurrentLevel = StartLevel;
	static int FinalLevel = 2;
	static public string LevelName = "GameScene";	
	static public int CurrentHealth = 3;
	static public bool GameStart = false;
	static int CurrentScore;
	static public int HighScore;
	static public bool PlayerShield;
	
	public OnGUI2D onGUI2D;

	//Initializations
	void Start(){
		AllLevelsComplete = false;
		CurrentScore = 0;
		PlayerShield = false;
	}

	//Ensures script is not destroyed when switching scenes
	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}

	//Accessor method for static variable
	public int getFinalLevel(){
		return FinalLevel;
	}

	//Accessor method for static variable
	public bool getAllLevelsComplete(){
		return AllLevelsComplete;
	}

	//Accessor method for static variable
	public int getCurrentLevel(){
		return CurrentLevel;
	}

	//Accessor method for static variable
	public string getLevelName(){
		return LevelName;
	}

	//Accessor method for static variable
	public int getCurrentHealth(){
		return CurrentHealth;
	}

	//Set Current Level to x
	public void setCurrentLevel(int x){
		CurrentLevel = x;
	}

	//Flag for achievement
	public void setAllLevelsComplete(bool x){
		AllLevelsComplete = x;
	}

	//Loads the next level
	public void LoadNextLevel(){
		if (CurrentLevel < FinalLevel) {
			Debug.Log (CurrentLevel);
			Application.LoadLevel (LevelName + CurrentLevel);
		} else {
			Application.LoadLevel ("MainMenu");
		}
		
	}

	//Resets values to default when starting a new game.
	public void resetCurrentLevel(){
		GameStart = true;
		CurrentLevel = 0;
		PlayerPrefs.SetInt ("CurrentScore", 0);
		PlayerPrefs.SetInt ("HighScore", 0);
		PlayerShield = false;

	}

	//Marks the start of a new game. Flag to reset values to default.
	public void setGameStart(bool x){
		GameStart = x;
	}

	//Saves Current Game Data and Returns to Main Menu
	public void SaveGameData(){

		PlayerPrefs.SetInt ("CurrentLevel", CurrentLevel);
		Application.LoadLevel ("MainMenu");
	}

	//Loads Previous Game Data and sets current to previous and then loads level
	public void LoadGameData(){
		CurrentLevel = PlayerPrefs.GetInt ("CurrentLevel");
		Application.LoadLevel (LevelName + CurrentLevel);
	}

	//updates high score
	public void UpdateHighScore(){

		if (CurrentScore > HighScore) {
			HighScore = CurrentScore;
		}

	}

	//returns high score
	public int getHighScore(){
		return HighScore;
	}

	//returns current score
	public int getCurrentScore(){
		return CurrentScore;}

	//Adds scene score to current score
	public void addCurrentScore(){
		CurrentScore += onGUI2D.getScore ();
	}

	//Accessor method for Player Shield
	public bool getPlayerShield(){
			Debug.Log ("GD: PlayerShield: " + PlayerShield);
		return PlayerShield;
	}

	//Turns player shield on
	public void enablePlayerShield(){
		PlayerShield = true;
	}

	//Turns player shield off
	public void disablePlayerShield(){
		PlayerShield = false;
	}


}
