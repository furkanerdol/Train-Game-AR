using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class hammer : MonoBehaviour {

	//Hammer and cube collision
	void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "Rock") {
			col.gameObject.SetActive (false);
			trainGame.rockActive = false;
			//Gain point
			trainGame.gameScore += 10;
		}
	}
}
