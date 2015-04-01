using UnityEngine;
using System.Collections;

public class EnemyControllerScript : MonoBehaviour {

	public GameObject manager;
	public GameDataScript gameDataScript;
	bool first;

	void Start(){
		manager = GameObject.FindGameObjectWithTag ("GameController");
		gameDataScript = manager.GetComponent<GameDataScript> ();
		first = true;
	}

	// Update is called once per frame
	// Enemy fly left
	void Update () {

		this.transform.position += new Vector3 (-0.1f, 0.0f, 0.0f);
	
	}

	//Patch for bug where collisions detecting twice
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.tag);
		if (other.tag == "Player") {
			Debug.Log ("EC: PlayerShield: " + gameDataScript.getPlayerShield ());

			if (!first) {
					Debug.Log ("Show up");

				if (gameDataScript.getPlayerShield ()) {
					gameDataScript.disablePlayerShield ();
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
