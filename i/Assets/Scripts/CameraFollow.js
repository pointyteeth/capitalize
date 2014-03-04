#pragma strict

var character : GameObject;

function Start () {
	character = GameObject.Find("i");
}

function Update () {
	transform.position.y = character.transform.position.y;
}