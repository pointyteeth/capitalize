using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

	public float magnitude;
	public float maxSize = 3.0f;
	public float jumpMagnitude;

	private int sign = 1;
	private float minSize = 1.0f;
	private bool jumping = false;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			if(!jumping) {
				jumping = true;
			}
		}

		if(jumping) {
			jump();
		}
	}

	private void jump() {
		float mag = sign * magnitude;
		float heightChange = jumpMagnitude * sign;
		transform.localScale += new Vector3(mag, mag, mag);
		transform.position += new Vector3(0.0f, heightChange, 0.0f);
		Debug.Log(transform.localScale);
		
		if (transform.localScale.x >= maxSize) 
		{
			sign = -1;
		}

		if (transform.localScale.x <= minSize) {
			sign = 1;
			jumping = false;
		}
	}
}
