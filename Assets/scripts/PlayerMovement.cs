using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	private Animator anim;
	private float startY;
	private Vector3 targetDirection;
	private GameObject player;
	public Camera camera;
	public GameObject leftArm;
	public GameObject rightArm;
	public GameObject leftLeg;
	public GameObject rightLeg;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		anim = player.GetComponent<Animator>();
		anim.SetFloat("Speed", 5.5f);
		startY = player.transform.position.y;
		targetDirection = new Vector3 (1, 0, 0);
	}
		
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (speed, 0, 0);
		gameObject.transform.position += move * Time.deltaTime;
		player.gameObject.GetComponent<Rigidbody> ().MoveRotation (Quaternion.LookRotation(targetDirection, Vector3.up));

		//detects if player is falling
		if (player.transform.position.y < startY - 1.5f) {
			GameObject.FindGameObjectWithTag ("portal").transform.parent = null;
			GameObject.FindGameObjectWithTag ("DeathTrigger").transform.parent = null;
			anim.SetFloat ("Speed", 0.0f);
			Rigidbody rb = (Rigidbody) player.GetComponent<Rigidbody> ();
			Vector3 pos = rb.transform.position;
			var dir = pos - new Vector3 (pos.x, pos.y - 3, pos.z);
			rightArm.GetComponent<Rigidbody> ().AddForce (dir * 300.0f);
			leftArm.GetComponent<Rigidbody> ().AddForce (dir * 300.0f);
			leftLeg.GetComponent<Rigidbody> ().AddForce (dir * 300.0f);
			rightLeg.GetComponent<Rigidbody> ().AddForce (dir * 300.0f);
			//camera.transform.LookAt (player.transform);
		}
	}
}
