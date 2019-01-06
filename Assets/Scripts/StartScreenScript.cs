using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour {

	static bool start = false;


	void Start () {
		if(!start) {
			GetComponent<SpriteRenderer>().enabled = true;
			Time.timeScale = 0;
		}
			start = true;
	}
	

	void Update () {
		if(Time.timeScale==0 && (Input.GetMouseButtonDown(0)) ) {
			Time.timeScale = 1;
			GetComponent<SpriteRenderer>().enabled = false;

		}
	}
}
