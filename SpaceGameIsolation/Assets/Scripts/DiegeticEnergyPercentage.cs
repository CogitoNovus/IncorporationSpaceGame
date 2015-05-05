using UnityEngine;
using System.Collections;

public class DiegeticEnergyPercentage : MonoBehaviour {

	// Update is called once per frame
	void Update () {

			
		GetComponent<TextMesh>().text = "Energy: " + PlayerResource.energyLvl/2 + "%";
	
	}
}
