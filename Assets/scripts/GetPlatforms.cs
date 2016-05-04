using UnityEngine;
using System.Collections;

public class GetPlatforms : MonoBehaviour {

	public GameObject[] platformModules;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public GameObject GetRandomPlatform() {
		int moduleIndex = Random.Range (0, 2);
		return platformModules[moduleIndex];
	}
}
