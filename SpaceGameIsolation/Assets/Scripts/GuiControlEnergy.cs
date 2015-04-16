using UnityEngine;
using System.Collections;

public class GuiControlEnergy : MonoBehaviour {

		
	// Update is called once per frame
	void Update () {
	
		float energyGui = PlayerResource.energyLvl;

		GetComponent<GUITexture>().pixelInset = new Rect(160,-120,energyGui,20);

	}
}
