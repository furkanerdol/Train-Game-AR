using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonScript : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject virtualButton;

	// Use this for initialization
	void Start () {

		//Virtual button setup
		virtualButton = GameObject.Find("vButton");
		virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		
	}
	
	public void OnButtonPressed (VirtualButtonBehaviour vb){

		// Start game with press virtual button
		Time.timeScale = 1;
		trainGame.start = true;
		Debug.Log ("Pressed");
	}
	
	public void OnButtonReleased (VirtualButtonBehaviour vb){
		Debug.Log ("Released");
	}
}
