using UnityEngine;
using System.Collections;

public class EnemyControllerScript : MonoBehaviour {

	public GameObject manager;
	public GameDataScript gameDataScript;
	bool first;

	void Start(){
		//Grab game data
		manager = GameObject.FindGameObjectWithTag ("GameController");
		gameDataScript = manager.GetComponent<GameDataScript> ();
		first = true;
	}

	// Update is called once per frame
	// Enemy fly left
	void Update () {

		this.transform.position += new Vector3 (-0.1f, 0.0f, 0.0f);
	
	}

	//first flag is patch for bug where collisions detecting twice
	void OnTriggerEnter2D(Collider2D other){
		//Only collide with Player
		if (other.tag == "Player") {

			if (!first) {
				//if shield is up, disable shield
				if (gameDataScript.getPlayerShield ()) {
					gameDataScript.disablePlayerShield ();
					Destroy (this.gameObject);
				} else {
					Application.LoadLevel ("DeathScene");
				}
			}

			else{
				first = false;
			}
		}

	}
}
