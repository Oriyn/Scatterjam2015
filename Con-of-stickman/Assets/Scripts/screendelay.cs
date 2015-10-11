using UnityEngine;
using System.Collections;

public class screendelay : MonoBehaviour {
	public float delayTime = 5;
	
	
	
	IEnumerator start () {
		yield return new WaitForSeconds(delayTime);
		
		Application.LoadLevel(1);
		
	}
	
}