using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int health = 10 ;

	void Update () {
	
		if (health <= 0)
			Destroy (gameObject);

	}

	
	public void damageplayer (int damage){

		 damage -= health  ;

	}

	public void OnCollisionEnter2D () {

		damageplayer(5) ; 
	}
}