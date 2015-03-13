using UnityEngine;
using System.Collections;

public class guiControl : MonoBehaviour {


	// Update is called once per frame

	void Update () {

		float oxyGui = OxygenMeter.oxyLvl; 

		//Debug.Log(oxyGui);

		GetComponent<GUITexture>().pixelInset = new Rect(160,-145,oxyGui,20);
	}
}
