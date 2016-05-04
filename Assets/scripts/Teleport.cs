using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;

public class Teleport : MonoBehaviour {

	public float speed;
	private bool upButtonDown = false;
	private bool leftButtonDown = false;
	private bool rightButtonDown = false;
	private bool jump = false;
	public GameObject player;
	public SmoothFollow sm;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 up = new Vector3 (speed, 0, 0);
		Vector3 left = new Vector3 (0, 0, speed);
		Vector3 right = new Vector3 (0, 0, -speed);

		if (Input.GetKey (KeyCode.UpArrow)) {
			gameObject.transform.position += up * Time.deltaTime;
			upButtonDown = true;
			jump = true;
		}
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			upButtonDown = false;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.position += left * Time.deltaTime;
			leftButtonDown = true;
			jump = true;
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			leftButtonDown = false;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.position += right * Time.deltaTime;
			rightButtonDown = true;
			jump = true;
		}
		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			rightButtonDown = false;
		}

		if (!upButtonDown && !rightButtonDown && !leftButtonDown && jump) {
			jump = false;
			Vector3 jumpPosition = new Vector3 (transform.position.x, player.transform.position.y, transform.position.z);
			player.transform.position = jumpPosition;
			transform.position = new Vector3 (player.transform.position.x, transform.position.y, player.transform.position.z);
			sm.EnableSmoothTemporary (0.25f);
		}
	}

}
