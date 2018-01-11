#pragma strict

function Start () {
    meMate();
}
 
function meMate(){
    //Mata a bala depois de 5 segundos que ela foi criada
    yield WaitForSeconds(2);
    Destroy(gameObject);
 
}