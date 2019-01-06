using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	Transform bird;
	float x;


	void Start () {
		GameObject GO = GameObject.FindGameObjectWithTag("Player");
		bird = GO.transform;
		x = transform.position.x - bird.position.x;
	}
	

	void Update () {
		if(bird != null) {
			Vector3 pos = transform.position;
			pos.x = bird.position.x + x;
			transform.position = pos;
		}
	}
}
