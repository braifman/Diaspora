using UnityEngine;
using System.Collections;

public class AdjustPlatforms : MonoBehaviour {

	public GameObject[] platforms;
	public float bound;

	// Use this for initialization
	void Start () {

		platforms = GameObject.FindGameObjectsWithTag ("platform");

		bound = platforms [0].gameObject.GetComponent<BoxCollider> ().bounds.max.y;

		for (int i = 0; i < platforms.Length; i++) {
			platforms [i].gameObject.transform.position += Vector3.up * (platforms [i].gameObject.GetComponent<BoxCollider> ().bounds.max.y - bound);
			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
