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
	
	public OnGUI2D onGUI2D;

	//Initializations
	void Start(){
		AllLevelsComplete = false;
		CurrentScore = 0;
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

	public void UpdateHighScore(){

		if (CurrentScore > HighScore) {
			HighScore = CurrentScore;
		}

	}

	public int getHighScore(){
		return HighScore;
	}

	public int getCurrentScore(){
		return CurrentScore;}

	public void addCurrentScore(){
		CurrentScore += onGUI2D.getScore ();
	}


}
