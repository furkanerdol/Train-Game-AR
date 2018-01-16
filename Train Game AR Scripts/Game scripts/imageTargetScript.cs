using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageTargetScript : MonoBehaviour {

	public GameObject imageTargetBlue;
	public GameObject hammer;
	public GameObject fireEx;

	//For use hammer or fire extinguisher
	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Hammer Cylinder") {
			fireEx.SetActive (false);
			hammer.SetActive (true);
		} else if (col.gameObject.name == "FireEx Cylinder"){
			hammer.SetActive (false);
			fireEx.SetActive (true);
		}


	}
}
