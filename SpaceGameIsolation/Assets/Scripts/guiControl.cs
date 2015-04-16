using UnityEngine;
using System.Collections;

public class guiControl : MonoBehaviour {

	public bool guiToggle = false; 

	// Update is called once per frame

	void Update () {

		float oxyGui = PlayerResource.oxyLvl; 

		float energyGui = PlayerResource.energyLvl;

		//Debug.Log(oxyGui);

		if (guiToggle == false){

		GetComponent<GUITexture>().pixelInset = new Rect(200,-145,oxyGui,20);
		
		}

		if (guiToggle == true){

			GetComponent<GUITexture>().pixelInset = new Rect(160,0,energyGui,20);

		}
	}
}
