using UnityEngine;
using System.Collections;

public class Story : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NextLevel(){
		Application.LoadLevel ("story");
		Debug.Log("Next scene");
	}
}
