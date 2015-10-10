using UnityEngine;
using System.Collections;

public class MovementP2 : MonoBehaviour {
	
	public float speed = 1.5f ;	
	public Vector3 com;
	public Rigidbody2D rb;


	void Start() {
		rb = GetComponent<Rigidbody2D>();
		rb.centerOfMass = com;
	}
	
	void Update () {
	
	    if (Input.GetKey(KeyCode.A))
	{
		transform.position += Vector3.left * speed * Time.deltaTime;
	}
	if (Input.GetKey(KeyCode.D))
	{
		transform.position += Vector3.right * speed * Time.deltaTime;
	}
	if (Input.GetKey(KeyCode.W))
	{
		transform.position += Vector3.up * speed * Time.deltaTime;
	}
	if (Input.GetKey(KeyCode.S))
	{
		transform.position += Vector3.down * speed * Time.deltaTime;
	}
   
  }
}