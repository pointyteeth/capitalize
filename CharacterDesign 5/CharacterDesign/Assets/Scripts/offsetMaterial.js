#pragma strict

var SCALE = -0.0625;

function Start() {
	renderer.material.mainTextureScale = Vector2(transform.localScale.x*SCALE, transform.localScale.z*SCALE);
	renderer.material.mainTextureOffset = Vector2(Offset(), Offset());
}

function Update() {

}

function Offset() {
	return Random.Range(0, 8)*SCALE;
}