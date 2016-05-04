using UnityEngine;
using System.Collections;

public class touchWall : MonoBehaviour {
	public GameObject firee;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col){
		if(col.gameObject.CompareTag("destroy")){
			Debug.Log ("destroy hit");
			Instantiate(firee, gameObject.transform.position, gameObject.transform.rotation);
			Destroy(gameObject);
		}
	}
}
