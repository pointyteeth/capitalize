using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	public float speed;

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)) {
			//Get Right Camera Boundaries
			Vector3 cameraLeft = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, -transform.position.z));

			Vector3 position = transform.position;
			position.x += (-1.0f * Time.deltaTime * speed);
			//Restrict
			if(position.x < (cameraLeft.x + this.transform.collider.bounds.size.x)) {
				position.x = cameraLeft.x + this.transform.collider.bounds.size.x;
			}
			transform.position = position;
		} 
		if (Input.GetKey(KeyCode.DownArrow)) {
			Vector3 position = transform.position;
			position.z += (-1.0f * Time.deltaTime * speed);
			transform.position = position;
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			//Get Right Camera Boundaries
			Vector3 cameraRight = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, 0.0f, -transform.position.z));

			Vector3 position = transform.position;
			position.x += (1.0f * Time.deltaTime * speed);

			//Restrict
			if(position.x > (cameraRight.x - this.transform.collider.bounds.size.x)) {
				position.x = cameraRight.x - this.transform.collider.bounds.size.x;
			}
			transform.position = position;
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			//Get Top of Camera Boundaries
			Vector3 topRight = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight, -transform.position.z));

			Vector3 position = transform.position;
			position.z += (1.0f * Time.deltaTime * speed);

			//Restrict 
			if(position.z > (topRight.z - this.transform.collider.bounds.size.z)) {
				position.z = topRight.z - this.transform.collider.bounds.size.z;
			}
			transform.position = position;
		}

	}
}
