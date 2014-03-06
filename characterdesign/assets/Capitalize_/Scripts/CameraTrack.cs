using UnityEngine;
using System.Collections;

public class CameraTrack : MonoBehaviour
{

	public Transform target;

	public float min_X, max_X;

		// Update is called once per frame
	void Update ()
	{
		if(target != null) {
			float z_axis, x_axis;
			z_axis = Mathf.Min (this.transform.position.z, target.position.z);
			if(target.position.x <= min_X)
			{
				x_axis = min_X;
			} else if(target.position.x >= max_X) {
				x_axis = max_X;
			} else {
				x_axis = target.position.x;
			}
			this.transform.position = new Vector3(x_axis, this.transform.position.y, z_axis);
		}

			
	}

	public void setTarget(Transform obj) {
		Debug.Log ("reset happened");
		this.target = obj;
		this.transform.position = new Vector3(target.position.x, this.transform.position.y, target.position.z);
	}
}

