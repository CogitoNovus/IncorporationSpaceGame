using UnityEngine;
using System.Collections;

public class deposit : MonoBehaviour {

	public float depositedMineral;

	public bool canDeposit;

	void Update(){

		if (canDeposit == true && Input.GetMouseButton(0)){

			Avatar.personalMineral -= 10;

			depositedMineral += 10;
		}

	}

	void OnTriggerStay (Collider other){

		if(other.gameObject.tag == "Player" && Avatar.personalMineral > 0){

			canDeposit = true;
		}

		else {canDeposit = false;}
	}

}

