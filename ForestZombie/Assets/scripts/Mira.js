#pragma strict

function Start () {
	GetComponent.<Animation>().wrapMode = WrapMode.Once;
}

function Update () {
	if(Input.GetMouseButtonDown(1)){
		GetComponent.<Animation>().Play("mirar");
	}
	
	if(Input.GetMouseButtonUp(1)){
		GetComponent.<Animation>().Play("tirar_mira");
	}
}
