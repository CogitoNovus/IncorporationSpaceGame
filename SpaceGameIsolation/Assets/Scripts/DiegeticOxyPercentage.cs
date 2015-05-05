using UnityEngine;
using System.Collections;

public class DiegeticOxyPercentage : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	
		GetComponent<TextMesh>().text = "Oxygen: " + PlayerResource.oxyLvl/200 + "%";

		if (PlayerResource.oxyLvl < 5000){

			GetComponent<TextMesh>().color = Color.red;
		}

		if (PlayerResource.oxyLvl > 5000){
			
			GetComponent<TextMesh>().color = Color.white;
		}
	}
}
