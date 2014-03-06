#pragma strict

var animator : Animator;

// state constants
var NEUTRAL = 0;
var UP = 1;
var DOWN = 2;
var RECOILING = 3;
var GAINING = 4;
var CAPITALIZING = 5;

// facing constants
var LEFT = 0;
var RIGHT = 1;

function Start () {
	animator = this.GetComponent(Animator);

}

function Update () {

        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");
 
        /*if(horizontal > 0) {
            transform.rotation.eulerAngles.x = 180;
        } else if(horizontal < 0) {
            transform.rotation.eulerAngles.x = 0;
        }*/
        if(transform.position.z < -171) {
	            animator.SetInteger("state", CAPITALIZING);
        } else {
	        if(vertical > 0) {
	            animator.SetInteger("state", UP);
	        } else if(vertical < 0) {
	            animator.SetInteger("state", DOWN);
	        } else {
	        	animator.SetInteger("state", NEUTRAL);
	        }
	    }
}