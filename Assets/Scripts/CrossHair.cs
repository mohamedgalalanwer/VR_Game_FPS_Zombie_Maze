using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour {
    public Texture2D crossHair;
    void OnGUI () {
        Rect rec = new Rect((Input.mousePosition.x - crossHair.width), ((Screen.height - Input.mousePosition.y+22) - crossHair.height), crossHair.width, crossHair.height );
        GUI.DrawTexture(rec, crossHair);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
