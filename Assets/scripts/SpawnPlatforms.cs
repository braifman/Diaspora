using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {
	public GameObject end;
	// Use this for initialization
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
		Debug.Log ("spawning");
		GameObject currModule = GameObject.FindGameObjectWithTag ("currModule");
		currModule.tag = "prevModule";
		GameObject platforms = GameObject.FindGameObjectWithTag ("platforms");
		GameObject module = platforms.GetComponent<GetPlatforms> ().GetRandomPlatform ();
		Vector3 startPosition = new Vector3 (end.transform.position.x, 0, 0);
		currModule = (GameObject) Instantiate(module, startPosition, Quaternion.identity);
		currModule.tag = "currModule";
	}
	// Update is called once per frame
	void Update () {
		
	}
}
