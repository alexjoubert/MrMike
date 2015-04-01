using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {
	
	public GameObject manager;
	public GameDataScript gameDataScript;

	//Grab game data
	void Start(){
		manager = GameObject.FindGameObjectWithTag ("GameController");
		gameDataScript = manager.GetComponent<GameDataScript> ();
	}
	

	//Patch for bug where collisions detecting twice
	void OnTriggerEnter2D(Collider2D other){
		//if player grabs powerup, enable shield
		if (other.tag == "Player") {
			gameDataScript.enablePlayerShield ();
			Destroy (this.gameObject);
		}
		
	}
}
