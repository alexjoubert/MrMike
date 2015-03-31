using UnityEngine;
using System.Collections;

public class Achievement1Toggle : MonoBehaviour {
	GameDataScript gameDataScript;
	GameObject FirstAchievement;

	// Use this for initialization
	void Start () {
		if (gameDataScript.getAllLevelsComplete()) {
			FirstAchievement.SetActive (true);
		}
	
	}

}
