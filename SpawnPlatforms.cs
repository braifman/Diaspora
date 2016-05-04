using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {
	public GameObject end;
	public int index;

	void Start () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("portal")) {
			GameObject prevModule = GameObject.FindGameObjectWithTag ("prevModule");
			if (prevModule) {
				Destroy (prevModule);
			}
			Spawn ();
		}


	}

	void Spawn() {
		SpawnStats spawn = (SpawnStats) FindObjectOfType<SpawnStats> ();
		GameObject currModule = GameObject.FindGameObjectWithTag ("currModule");
		currModule.tag = "prevModule";
		GetPlatforms platforms = GameObject.FindGameObjectWithTag ("platforms").GetComponent<GetPlatforms>();

		if (spawn.currPart == 0) {
			GameObject module = platforms.GetRandomPlatform ();
			GameObject currPart = module.transform.GetChild (0).gameObject;
			Vector3 startPosition = new Vector3 (end.transform.position.x, 0, 0);
			currModule = (GameObject)Instantiate (currPart, startPosition, Quaternion.identity);
		} else {
			currModule = platforms.getPlatform (spawn.currModule);
			GameObject currPart = currModule.transform.GetChild (spawn.currPart).gameObject;
			currModule = Instantiate (currPart);
		}
		currModule.tag = "currModule";
		spawn.updatePart ();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
