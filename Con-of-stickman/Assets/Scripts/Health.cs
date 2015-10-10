using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	int health = 10 ;

	void Update () {
	
		if (health <= 0)
			Destroy (gameObject);


	}
}
