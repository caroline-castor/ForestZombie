#pragma strict
var Bullet: Transform;
var Spawn: Transform;


function Start () {
	
}

function Update () {
	if(Input.GetMouseButton(0)){
		Shot();
	}
}

function Shot(){
	var pel = Instantiate(Bullet, Spawn.position, Spawn.rotation);
	pel.GetComponent.<Rigidbody>().AddForce(transform.forward * 8000);
	 
	

}
