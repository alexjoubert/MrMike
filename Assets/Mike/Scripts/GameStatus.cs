using UnityEngine;
using System.Collections;

//Currently not in use. Was meant to optimize game flow
public class GameStatus : MonoBehaviour {

	GameDataScript gameDataScript;
	OnGUI2D onGUI2D;

	void Update(){

	}
	
	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}


	
}
