using UnityEngine;
using System.Collections;

public class MenuRestart : MonoBehaviour {
	public CharacterMovement player;

	private bool paused = false;
	public float x, y;

	private bool gameOver = false;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Escape)) {
			paused = !paused;
		}
	}

	void OnGUI() {
		if(!(gameOver)) {
		if(paused) {
			displayMenu();
		} else {
			TakeDownMenu();
		}
		}
	}

	void displayMenu() {
		player.stopMovement();
		if (GUI.Button(new Rect(x,y,300,100),"Restart")) {
			Application.LoadLevel(0);
		}
	}

	void TakeDownMenu() {
		player.beginMovement();
	}

	public void finishGame() {
		gameOver = true;
	}

	public void pauseGame() {

		paused = true;
	}
}
