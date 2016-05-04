using UnityEngine;
using System.Collections;

public class helpscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NextLevel(){
		Application.LoadLevel ("help");
		Debug.Log("Next scene");
	}
}
