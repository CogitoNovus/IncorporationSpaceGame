using UnityEngine;
using System.Collections;

public class scanFilter : MonoBehaviour {

	public MonoBehaviour noiseFilter;

	// Update is called once per frame
	void Update () {

		if (Avatar.scan == true){

			noiseFilter.enabled = true;
		}

		if (Avatar.scan == false){
			
			noiseFilter.enabled = false;
		}
	}
}
