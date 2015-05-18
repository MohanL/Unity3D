using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {

	// Update is called once per frame
	void LateUpdate () {
		transform.Rotate(new Vector3 (0, 30, 30)*Time.deltaTime);
	}
}
