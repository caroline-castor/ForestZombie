    var muzzleFlash : Renderer;
    var muzzleLight : Light;
     
    function Start()
    {
        muzzleFlash.enabled = false;
        muzzleLight.enabled = false;
    }
     
    function Update()
    {
        if(Input.GetMouseButton(0))
        {
            Shoot();
        }
    }
     
    function Shoot()
    {
        muzzleFlash.GetComponent.<Renderer>().enabled = true;
        muzzleLight.enabled = true;
        yield WaitForSeconds(0.03);
        muzzleFlash.GetComponent.<Renderer>().enabled = false;
        muzzleLight.enabled = false;
    }