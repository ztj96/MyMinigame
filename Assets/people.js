#pragma strict

function Start () {

}

function Update () {
	if (Input.GetButtonDown("Jump")) {
		transform.Translate(0, -2, 0);
	}
	if (Input.GetButtonUp("Jump")) {
		transform.Translate(0,2,0);
	}
}