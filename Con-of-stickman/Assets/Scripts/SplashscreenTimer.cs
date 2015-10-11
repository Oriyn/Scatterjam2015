using UnityEngine;
using System.Collections;

public class SplashscreenTimer : MonoBehaviour {
	public float delayTime = 5;
	public bool done = false;

	private float timer;

	void Start () {
		timer = delayTime;

	
		StartCoroutine ("SomeFunction");

	}
	

	void Update () {
		timer -= Time.deltaTime;



		if (timer > 0)
			return;

		if (done)
			Application.LoadLevel (1);


	}

   IEnumerator SomeFunction() {



		yield return null;

		done = true;

  }
}