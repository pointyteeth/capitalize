using UnityEngine;
using System.Collections;

public class WordCollect : MonoBehaviour {
	
	public string word;
	public wordManager wordManager;
	
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision col) {
		//May need to check if player collision or not
		wordManager.addWord(word);
		Destroy(gameObject);
	}
}
