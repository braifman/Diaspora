using UnityEngine;
using System.Collections;

namespace DigitalRuby.PyroParticles{
	public class fire : MonoBehaviour {

		public GameObject fireball;
	


		private FireBaseScript currentPrefabScript;




	// Use this for initialization
		void Start () {


		}

		// Update is called once per frame
		void Update () {
			
			pewpew ();
		
		}

		private void pewpew(){

			if (Input.GetKeyDown(KeyCode.F)){
				BeginEffect();
			}
		}


		private void BeginEffect()
		{

				Debug.Log ("It's working");
			Instantiate (fireball, 
				new Vector3(GameObject.Find ("char_ethan").transform.position.x, 
				GameObject.Find ("char_ethan").transform.position.y+0.8f,
				GameObject.Find ("char_ethan").transform.position.z), 
				GameObject.Find("char_ethan").transform.rotation);

		}
	}
}
