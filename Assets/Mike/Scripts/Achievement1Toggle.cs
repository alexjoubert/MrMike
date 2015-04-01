using UnityEngine;
using System.Collections;

//Not complete. Used for achievement
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
