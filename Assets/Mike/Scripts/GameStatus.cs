using UnityEngine;
using System.Collections;

public class GameStatus : MonoBehaviour {

	GameDataScript gameDataScript;
	OnGUI2D onGUI2D;

	void Update(){

	}
	
	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}


	
}
