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
		FindObjectOfType<SpawnStats>().currModule = moduleIndex;
		return platformModules[moduleIndex];
	}

	public GameObject getPlatform(int index) {
		return platformModules [index];
	}
}
