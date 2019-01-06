using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public float up;
	public float right;

	bool Flap = false;

	
	public bool death = false;
    float delay;

	public bool immortal = false;

	Animator anim;


	void Start () {
		anim = transform.GetComponentInChildren<Animator>();
	}


	void Update() {
		if(death) {
			delay -= Time.deltaTime;

			if(delay <= 0) {
				if(Input.GetMouseButtonDown(0) ) {
					Application.LoadLevel( Application.loadedLevel );
				}
			}
		}
		else {
			if(Input.GetMouseButtonDown(0) ) {
				Flap = true;
			}
		}
	}


	void FixedUpdate () {

		if(death)
			return;

		GetComponent<Rigidbody2D>().AddForce( Vector2.right * right );

		if(Flap) {
			GetComponent<Rigidbody2D>().AddForce( Vector2.up * up );
			anim.SetTrigger("Flap");


			Flap = false;
		}

		if(GetComponent<Rigidbody2D>().velocity.y > 0) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		else {
			float angle = Mathf.Lerp (0, -90, (-GetComponent<Rigidbody2D>().velocity.y / 3f) );
			transform.rotation = Quaternion.Euler(0, 0, angle);
		}
	}


	void OnCollisionEnter2D(Collision2D collision) {
		if(immortal)
			return;

		anim.SetTrigger("Death");
		death = true;
		delay = 0.5f;
	}
}
