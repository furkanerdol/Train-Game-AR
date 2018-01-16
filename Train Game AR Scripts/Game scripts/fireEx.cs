using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireWater : MonoBehaviour {

	//Fire extinguisher collision with fire
	void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "fires") {
			trainGame.fireActive = false;

			//Gain point
			trainGame.gameScore += 20;
		}
	}
}
