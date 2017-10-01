using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public float gravity;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
	
		Vector3 movement = new Vector3 (-moveHorizontal, gravity, gravity);
		rb.AddForce (movement * speed);
	}
}
