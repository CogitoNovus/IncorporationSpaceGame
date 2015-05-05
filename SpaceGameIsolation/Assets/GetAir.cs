using UnityEngine;
using System.Collections;

public class GetAir : MonoBehaviour {

	void OnTriggerStay (Collider other){

		if (other.gameObject.tag == "Player" && PlayerResource.oxyLvl < PlayerResource.maxOxy){

			PlayerResource.oxyLvl += 3;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
