using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	GameDataScript gameDataScript;

	// x = scene to change to
	public void ChangeToScene (string x) {
		Application.LoadLevel (x);
	}


	public void QuitGame(){
			Application.Quit();
	}

}
