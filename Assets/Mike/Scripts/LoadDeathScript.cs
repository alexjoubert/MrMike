using UnityEngine;
using System.Collections;

public class LoadDeathScript : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other){

		//Load Death scene
		Application.LoadLevel ("DeathScene");
	}
}
