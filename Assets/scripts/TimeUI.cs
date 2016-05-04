using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class TimeUI : MonoBehaviour {

	public Text t;
	private string temp;
	public float time;

	// Use this for initialization
	void Start () {
		RestartTime (); // doesn't work?
		t = GetComponent<Text> ();
		temp = t.text;

	}

	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		t.text = temp + Math.Round((double)time, 2);
	}

	public void RestartTime() {
		Debug.Log ("restart time");
		time = 0;
	}
}

