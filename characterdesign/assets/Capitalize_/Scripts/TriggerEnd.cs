using UnityEngine;
using System.Collections;

public class TriggerEnd : MonoBehaviour {

	public wordManager wordManager;
	public Transform topLeft;
	public Transform bottomRight;

	public CharacterMovement character;

	public MenuRestart menu;

	public GameObject determined;
	public GameObject sharp;
	public GameObject driven;
	public GameObject observant;
	public GameObject daring;
	public GameObject hungry;
	public GameObject enticed;
	public GameObject pulled;
	public GameObject inquisitive;
	public GameObject drawn;
	public GameObject clever;
	public GameObject diligent;
	public GameObject enterprising;

	private bool flag = true;
	

	// Update is called once per frame
	void OnCollisionEnter () {
		if(flag) {
		character.stopMovement();
		Debug.Log("STOP");
		foreach (string word in wordManager.words) {
			Vector3 randomPosition = new Vector3(Random.Range (topLeft.position.x, bottomRight.position.x), topLeft.position.y, Random.Range (bottomRight.position.z, topLeft.position.z));
			if(word == "determined") {
				Instantiate(determined, randomPosition, topLeft.rotation);
			} else if(word == "sharp") {
				Instantiate(sharp, randomPosition, topLeft.rotation);
			} else if (word == "driven") {
				Instantiate(driven, randomPosition, topLeft.rotation);
			} else if (word == "observant") {
				Instantiate(observant, randomPosition, topLeft.rotation);
			} else if (word == "daring") {
				Instantiate(daring, randomPosition, topLeft.rotation);
			} else if (word == "hungry") {
				Instantiate(hungry, randomPosition, topLeft.rotation);
			} else if (word == "enticed") {
				Instantiate(enticed, randomPosition, topLeft.rotation);
			} else if (word == "pulled") {
				Instantiate(pulled, randomPosition, topLeft.rotation);
			} else if (word == "inquisitive") {
				Instantiate(inquisitive, randomPosition, topLeft.rotation);
			} else if (word == "drawn") {
				Instantiate(drawn, randomPosition, topLeft.rotation);
			} else if (word == "clever") {
				Instantiate(clever, randomPosition, topLeft.rotation);
			} else if (word == "diligent") {
				Instantiate(diligent, randomPosition, topLeft.rotation);
			} else if (word == "enterprising") {
				Instantiate(enterprising, randomPosition, topLeft.rotation);
			}

		}
		flag = false;


			
			menu.pauseGame();
		}
	}
}
