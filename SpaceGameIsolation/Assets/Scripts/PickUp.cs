using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	public bool canPickUp = false;

	void OnTriggerEnter (Collider other){

		if (other.gameObject.tag == "Player"){
		canPickUp = true;
		}
	}

	void OnTriggerExit (Collider other){

		if (other.gameObject.tag == "Player"){
		canPickUp = false;
		}
	}

	// Update is called once per frame
	void Update () {
	
		if (canPickUp == true){

			if (Input.GetKeyDown(KeyCode.LeftAlt)){

				Destroy(this.gameObject);

				itemCount.items += 1;

				FindLight.PickedUp = true;
			}

		}
	}
}
