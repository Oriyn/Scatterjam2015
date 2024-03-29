﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 1.5f ; 
	public Vector3 com;
	public Rigidbody2D rb;
	
	
	void Start() {
		rb = GetComponent<Rigidbody2D>();
		rb.centerOfMass = com;
	}

	void Update () 
	{
		    if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		    if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
			if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
			if (Input.GetKey(KeyCode.DownArrow))
		{
		     transform.position += Vector3.down * speed * Time.deltaTime;
		}
	
	}
}