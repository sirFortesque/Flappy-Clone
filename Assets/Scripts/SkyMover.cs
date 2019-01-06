using UnityEngine;
using System.Collections;

public class SkyMover : MonoBehaviour {

	Rigidbody2D bird;

	void Start () {
		GameObject GO = GameObject.FindGameObjectWithTag("Player");		
		bird = GO.GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		float speed = bird.velocity.x * 0.75f;
		transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
	}
}
