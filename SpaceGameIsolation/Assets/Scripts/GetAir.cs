using UnityEngine;
using System.Collections;

public class GetAir : MonoBehaviour {

	void OnTriggerStay (Collider other){

		if (other.gameObject.tag == "Player" && PlayerResource.oxyLvl < PlayerResource.maxOxy){

			PlayerResource.oxyLvl += 20;
		}


		if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Return)){

			timeSystem.awake = false;
		}
	}

}
