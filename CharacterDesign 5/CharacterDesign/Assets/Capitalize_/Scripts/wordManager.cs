using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class wordManager : MonoBehaviour {

	public List<string> words;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addWord(string word) {
		words.Insert(words.Count, word);
	}
}
