#pragma strict

function Start () {

}

function Update () {
	transform.Rotate(0, 0, -40*Time.deltaTime);
}