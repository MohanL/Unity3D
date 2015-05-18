using UnityEngine;
using System.Collections;

public class playercontroller : MonoBehaviour {
	
	public float speed;
	
	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float moveUpDown = Input.GetAxis ("HV");

		Vector3 movement = new Vector3 (moveHorizontal, moveUpDown, moveVertical);
		
		rb.AddForce (movement * speed);
	}
	void OnTriggerEnter(Collider other) {
		(other.gameObject);
	}
}