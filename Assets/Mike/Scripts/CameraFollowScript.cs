using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour {

	public Transform player;
	
	// Update Camera's position every time player moves. (ie. camera follows player)
	void Update () {
		transform.position = new Vector3 (player.position.x + 6, 0, -10);
	
	}
}
