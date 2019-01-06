using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	static int score = 0;
	static int highScore = 0;
	static Score example;
	Bird bird;

	static public void Point() {
		if(example.bird.death)
			return;

		score++;

		if(score > highScore) {
			highScore = score;
		}
	}

	
	void Start() {
		example = this;
		GameObject GO = GameObject.FindGameObjectWithTag("Player");
		bird = GO.GetComponent<Bird>();
		score = 0;
		highScore = PlayerPrefs.GetInt("highScore", 0);
	}

	void OnDestroy() {
		example = null;
		PlayerPrefs.SetInt("highScore", highScore);
	}

	void Update () {
		GetComponent<GUIText>().text = "Score: " + score + "\nHigh Score: " + highScore;
	}
}
