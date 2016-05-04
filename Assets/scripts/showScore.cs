using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showScore : MonoBehaviour {

	public float distance;
	public float fastestSpeed;
	public float time;
	public Text text;
	public int highscore;


	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		highscore = PlayerPrefs.GetInt("High Score");

	}
	
	// Update is called once per frame
	void Update () {

		text.text = "Distance = " + distance + "m\nFastest Speed = " + fastestSpeed + "\n Time = " + time + "s\n Score = " + calculateScore (distance, fastestSpeed, time) + "\n HighScore = " + High(calculateScore (distance, fastestSpeed, time)) + "\nPress 'space' to restart!"; 
	}

	// revisions fosho
	public int calculateScore(float d, float s, float t) {
		return (int)(((10 * d) + (100 * t)) * s);
	}

	public int High(int score){
		if (score > highscore) {
			highscore = score;
			PlayerPrefs.SetInt("High Score", highscore);
		}
		return highscore;
	}

}
