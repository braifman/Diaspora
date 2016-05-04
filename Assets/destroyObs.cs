using UnityEngine;
using System.Collections;

public class destroyObs : MonoBehaviour {

	public GameObject firee;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.CompareTag("destroy")) {

			Instantiate (firee, col.transform.position, col.transform.rotation);

			Destroy(col.gameObject);
			Debug.Log ("what is going on");
		}
			
	}


}
