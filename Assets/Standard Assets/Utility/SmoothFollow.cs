using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Utility
{
	public class SmoothFollow : MonoBehaviour
	{

		// The target we are following
		public Transform target;
		// The distance in the x-z plane to the target

		public float damping;
		public float currentDamping;
		Vector3 offset;

		public bool smooth;

		Vector3 velocity = Vector3.zero;
		// Use this for initialization
		void Start() {
			offset = -target.position + transform.position;
		}

		// Update is called once per frame
		void LateUpdate()
		{
			if (smooth)
				transform.position = Vector3.SmoothDamp (transform.position, target.position + offset, ref velocity, Time.deltaTime * currentDamping);
			else
				transform.position = target.position + offset;
		}

		public void EnableSmoothTemporary(float time){
			StartCoroutine(DoEnableSmoothTemporary(time));
		}

		public IEnumerator DoEnableSmoothTemporary(float time){
			smooth = true;
			// yield return new WaitForSeconds(time)//;
			float t = 0;
			currentDamping = damping;
			while (t < time) {
				yield return null;
				t += Time.deltaTime;
				currentDamping = damping * (1.0f - t / time);
			}

			smooth = false;
		}
	}


}