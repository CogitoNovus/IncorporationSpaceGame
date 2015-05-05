using UnityEngine;
using System.Collections;

public class deposit : MonoBehaviour {

	public static int depositedMineral;

	public bool canDeposit;

	void Update(){

		Debug.Log(canDeposit);

		if (Avatar.personalMineral > 0){

		if (canDeposit == true && Input.GetMouseButton(0) && Avatar.personalMineral != 0){

			Avatar.personalMineral -= 1;

			depositedMineral += 1;
		}
		}

	}

	void OnTriggerStay (Collider other){

		if(other.gameObject.tag == "Player"){

			canDeposit = true;
		}

	}

	void OnTriggerExit (Collider other){

		if(other.gameObject.tag == "Player"){

			canDeposit = false;

		}
	}

}

