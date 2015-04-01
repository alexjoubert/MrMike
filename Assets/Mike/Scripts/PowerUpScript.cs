using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {
	
	public GameObject manager;
	public GameDataScript gameDataScript;
	
	void Start(){
		manager = GameObject.FindGameObjectWithTag ("GameController");
		gameDataScript = manager.GetComponent<GameDataScript> ();
	}
	

	//Patch for bug where collisions detecting twice
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.tag);
		if (other.tag == "Player") {
			Debug.Log ("PU: PlayerShield: " + gameDataScript.getPlayerShield ());
					
			gameDataScript.enablePlayerShield ();
			Debug.Log ("PU after: PlayerShield: " + gameDataScript.getPlayerShield ());
					
					//Destroy (this);
			

		}
		
	}
}
