using UnityEngine;
using System.Collections;

public class DestroyOnTimer : MonoBehaviour {

	public float timeLeft;

	private bool timerStarted = false;
	
	// Update is called once per frame
	void Update () {
		if(timerStarted) {
			timeLeft -= Time.deltaTime;

			if(timeLeft <= 0.0f) {
				Destroy(gameObject);
			}
		}
	}

	void OnCollisionEnter(Collision col) {
		timerStarted = true;
	}
}
