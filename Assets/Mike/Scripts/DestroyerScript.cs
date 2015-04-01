using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	//Destroy object if not player. Used for optimizing game and debugging.
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			Application.LoadLevel ("DeathScene");
			return;}
		if(other.gameObject.transform.parent){
			Destroy(other.gameObject.transform.parent.gameObject);
			}
		else{
			Destroy(other.gameObject);
			}
	}
}