using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int health = 100 ;

	void Update () {
	
		if (health <= 0)
			Destroy (gameObject);
	

	}

	
	public void damageplayer (int damage){

		 health -= damage  ;

	}

	public void OnCollisionEnter2D () {

		damageplayer(1) ; 
	}


	void OnDestroy() {

		Application.LoadLevel (3);


	}

}