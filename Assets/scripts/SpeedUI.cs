using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class SpeedUI : MonoBehaviour {

	public GameObject multiplyer;
	public Text t;
	private string temp;

	// Use this for initialization
	void Start () {
		t = GetComponent<Text> ();
		temp = t.text;
	
	}

	
	// Update is called once per frame
	void Update () {

		float multi = multiplyer.GetComponent<speedUp> ().speedMultiplyer;
		multi = (float)Math.Round ((double)multi, 2);

		t.text = temp + multi;
	}
}
