using UnityEngine;
using System.Collections;

public class GuiControlOxygen : MonoBehaviour {


	// Update is called once per frame
	void Update () {
	
		float oxyGui = PlayerResource.oxyLvl; 

		GetComponent<GUITexture>().pixelInset = new Rect(160,-145,oxyGui,20);
		GetComponent<GUITexture>().color = Color.blue;
	}
}
