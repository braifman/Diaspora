using UnityEngine;
using System.Collections;

public class slowOrb : MonoBehaviour {

	//public GameObject player;
	public speedUp speed;
	bool smallOrb = false;

	// Use this for initialization
	void Start () {
		speed = FindObjectOfType<speedUp> ();
		if (gameObject.tag == "small") {
			smallOrb = true;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			Debug.Log ("collide");
			if (smallOrb) {
				speed.slowAmount = .025f;
				speed.slowDuration = .5f;
			} else {
				speed.slowAmount = .5f;
				speed.slowDuration = 5f;
			}
			speed.slowDown = true;
			speed.initiateSlowDown = true;
			Destroy (gameObject);
		}
	}
}
