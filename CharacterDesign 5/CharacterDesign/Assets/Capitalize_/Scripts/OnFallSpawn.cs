using UnityEngine;
using System.Collections;

public class OnFallSpawn : MonoBehaviour {

	public  GameObject Player;
	public Transform spawn;

	public CameraTrack camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		Destroy(col.gameObject);
		GameObject player = (GameObject)Instantiate(Player, spawn.position, spawn.rotation); 
		camera.setTarget(player.transform);
	}
}
