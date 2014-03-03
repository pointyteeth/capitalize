#pragma strict

function Start() {
	renderer.material.mainTextureOffset = Vector2 (Offset(), Offset());
}

function Update() {

}

function Offset() {
	return Random.Range(0, 4)*0.25;
}