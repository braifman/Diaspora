using UnityEngine;
using System.Collections;

public class speedUp : MonoBehaviour {

	public GameObject player;
	public GameObject teleporter;
	public float speedMultiplyer = 1;
	public float fastestSpeed = 1;
	public bool initiateSpeed = true;
	private float tempPlayer;
	private float tempTele;
	public bool slowDown = false;
	public bool initiateSlowDown = false;
	public float slowAmount;
	public float slowDuration;

	// Use this for initialization
	void Start () {
		tempPlayer = player.GetComponent<PlayerMovement> ().speed;
		tempTele = teleporter.GetComponent<Teleport> ().speed;
	}
	
	// Update is called once per frame
	void Update () {

		if (speedMultiplyer > fastestSpeed) {
			fastestSpeed = speedMultiplyer;
		}

		if (initiateSpeed && !slowDown) {
			StartCoroutine (initiate ());
		}

		if (initiateSlowDown && slowDown) {
			StartCoroutine (initiateSlow ());
		}

	}
	int timesSpedUp = 0;
	float multiTemp = .3f;
	IEnumerator initiate() {
		
		initiateSpeed = false;
		//yield return new WaitForSeconds(5);

		float time = 0f;
		float totalTime = 10f;
		float initSpeed = speedMultiplyer;
		float targetSpeed = speedMultiplyer + multiTemp;

		while (time < totalTime && !slowDown) {
			
			speedMultiplyer = Mathf.Lerp (initSpeed, targetSpeed, time / totalTime);

			yield return null;

			time += Time.deltaTime;

			player.GetComponent<PlayerMovement> ().speed = tempPlayer * speedMultiplyer;
			teleporter.GetComponent<Teleport> ().speed = tempTele * speedMultiplyer;

		}
		timesSpedUp++;
		yield return null;
		initiateSpeed = true;
		Debug.Log (timesSpedUp);
	}

	IEnumerator initiateSlow() {
		
		initiateSlowDown = false;

		float time = 0f;
		float totalTime = slowDuration;
		float initSpeed = speedMultiplyer;
		float targetSpeed = speedMultiplyer - slowAmount;

		while (time < totalTime && speedMultiplyer > 1) {

			speedMultiplyer = Mathf.Lerp (initSpeed, targetSpeed, time / totalTime);

			yield return null;

			time += Time.deltaTime;

			player.GetComponent<PlayerMovement> ().speed = tempPlayer * speedMultiplyer;
			teleporter.GetComponent<Teleport> ().speed = tempTele * speedMultiplyer;
		}

		yield return null;
			
		slowDown = false;
	}
		
}
