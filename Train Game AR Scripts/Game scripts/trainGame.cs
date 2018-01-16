using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainGame : MonoBehaviour {

	public GameObject gameText;
	public static int gameScore = 0;
	private TextMesh textObject;

	public static bool start = false;

	public static bool rockActive = false;
	public static bool fireActive = false;

	public GameObject rock;
	public GameObject fires;

	//Random positions
	private int rockPos;
	private int firePos;

	//System start
	private bool init = true;

	//Referance posints for random positions
	public GameObject[] points;


	// Use this for initialization
	void Start () {

		textObject = gameText.GetComponent<TextMesh> ();
		textObject.text = "Welcome!";

	}
	
	// Update is called once per frame
	void Update () {

		if (init) {

			init = false;
			rockPos = Random.Range (5, 25);
			GameObject point1 = points [rockPos];

			firePos = Random.Range (5, 25);

			//Fire position should not equal rock position
			while (firePos == rockPos) {
				firePos = Random.Range (5, 25);
			}

			GameObject point2 = points [firePos];

			//Set rock position
			rock.transform.position = point1.transform.position;

			//Set fire position 
			Vector3 pos;
			pos.x = point2.transform.position.x;
			pos.y = point2.transform.position.y + 1.2f;
			pos.z = point2.transform.position.z;
			fires.transform.position = pos;

			rock.SetActive (true);
			rockActive = true;
			fires.SetActive (true);
			fireActive = true;

			//Game pause for first open
			Time.timeScale = 0;

		} else {

			if (start) {

				//Write game score
				textObject.text = "Score : " + gameScore;

				//New rock position
				if (!rockActive) {
					rockPos = Random.Range (0, points.Length-1);
					GameObject point1 = points [rockPos];
					rock.transform.position = point1.transform.position;
					rock.SetActive (true);
					rockActive = true;
				}

				//New fire psoition
				if (!fireActive) {
					firePos = Random.Range (0, points.Length-1);

					while (firePos == rockPos) {
						firePos = Random.Range (0, points.Length-1);
					}

					GameObject point2 = points [firePos];
					Vector3 pos;
					pos.x = point2.transform.position.x;
					pos.y = point2.transform.position.y + 1.2f;
					pos.z = point2.transform.position.z;
					fires.transform.position = pos;
					fires.SetActive (true);
					fireActive = true;
				}
			}
		
		}

	}

	//Collision for train with rock or fires
	void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "Rock" || col.gameObject.name == "fires") {
			start = false;

			//End game
			textObject.text = "Your Score : " + gameScore + "!";
			gameScore = 0;
			Time.timeScale = 0;
		}


	}
}
