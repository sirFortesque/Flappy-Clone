using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {
	
	float up = 0.8430938f;
	float down = -0.003243029f;
    int BGnum = 6;

	void Start() {
		GameObject[] tubes = GameObject.FindGameObjectsWithTag("tube");

		foreach(GameObject tube in tubes) {
			Vector3 pos = tube.transform.position;
			pos.y = Random.Range(down, up);
			tube.transform.position = pos;
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		float width = ((BoxCollider2D)collider).size.x;
		Vector3 position = collider.transform.position;
		position.x += width * BGnum;

		if(collider.tag == "tube") {
			position.y = Random.Range(down, up);
		}
		collider.transform.position = position;

	}
}
