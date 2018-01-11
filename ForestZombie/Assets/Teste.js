#pragma strict

var velTiro = 150.0;
var balaObj : GameObject;
 
function Atira () {
 var bala = Instantiate(balaObj,transform.position,transform.rotation); 
 bala.AddComponent(Rigidbody);
 bala.transform.position = transform.position;
 bala.transform.rotation= transform.rotation;
 bala.GetComponent.<Rigidbody>().velocity = transform.forward * velTiro*-1;
 bala.GetComponent.<Rigidbody>().mass = 1;
 GetComponent.<AudioSource>().Play();
 }
 
function Update () {
 //Atira quando aperta o botão
 if (Input.GetButtonDown("Fire1")) {
 Atira();
 }
 }