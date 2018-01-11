    //Slap this script on to the main camera or similar and you'll have a GUI driven crosshair in no time without the use of a texture.
     
    #pragma strict
     
    var drawCrosshair = true;
     
    var crosshairColor = Color.white; //The crosshair color
     
    var width : float = 1; //Crosshair width
    var height : float = 3; //Crosshair height
     
    class spreading{
    var spread = 20.0; //Adjust this for a bigger or smaller crosshair
    var maxSpread = 60.0;
    var minSpread = 20.0;
    var spreadPerSecond = 30.0;
    var decreasePerSecond = 25.0;
    }
    var spread : spreading;
     
    private var tex : Texture2D;
     
    private var newHeight : float;
    private var lineStyle : GUIStyle;
     
    function Awake (){
    tex = Texture2D(1,1);
    SetColor(tex, crosshairColor); //Set color
    lineStyle = GUIStyle();
    lineStyle.normal.background = tex;
    }
     
    function OnGUI (){
    var centerPoint = Vector2(Screen.width/2,Screen.height/2);
    var screenRatio : float = Screen.height/100;
     
    newHeight = height * screenRatio;
     
    if (drawCrosshair) {
GUI.Box(new Rect(centerPoint.x - (width /2), centerPoint.y - (newHeight + spread.spread), width, newHeight), GUIContent.none, lineStyle);
GUI.Box(new Rect(centerPoint.x - (width /2), (centerPoint.y + spread.spread), width, newHeight), GUIContent.none, lineStyle);
GUI.Box(new Rect((centerPoint.x + spread.spread), (centerPoint.y - (width /2)), newHeight, width), GUIContent.none, lineStyle);
GUI.Box(new Rect(centerPoint.x - (newHeight + spread.spread), (centerPoint.y - (width /2)), newHeight, width), GUIContent.none, lineStyle);
}
 
    if(Input.GetMouseButton(0)){
    spread.spread += spread.spreadPerSecond * Time.deltaTime; //Make spreading "smooth" and not abrupt
    }else {
    if(Input.GetKey("w")){
    spread.spread += spread.spreadPerSecond * Time.deltaTime; //Make spreading "smooth" and not abrupt
    }
    Fire();
    }
    
     
    spread.spread -= spread.decreasePerSecond * Time.deltaTime; //Decrement the spread
    spread.spread = Mathf.Clamp(spread.spread, spread.minSpread, spread.maxSpread);
    }
     
    function Fire(){
    //Carry out your normal shooting and stuff
    }
    //Applies color to the crosshair
    function SetColor(myTexture : Texture2D, myColor : Color){
    for (var y : int = 0; y < myTexture.height; ++y){
    for (var x : int = 0; x < myTexture.width; ++x){
    myTexture.SetPixel(x, y, myColor);
    }
    }
    myTexture.Apply();
    }