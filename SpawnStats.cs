using UnityEngine;
using System.Collections;

public class SpawnStats : MonoBehaviour {
	public int currModule;
	public int currPart;
	// Use this for initialization
	public void Start () {
		currModule = 0;
		currPart = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void updatePart() {
		currPart = (currPart + 1) % 4;
	}
}
